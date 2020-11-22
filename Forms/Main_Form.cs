using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class Main_Form : Form
    {
        List<DBS.Kind> m_kind_list;
        List<DBS.Menu> m_menu_list;
        List<DBS.Menu> m_sale_menu_list = new List<DBS.Menu>();
        public DBS.Kind m_kind_current
        {
            get {
                int index = comboBox_Kind.SelectedIndex;
                if (index >= 0)
                {
                    return m_kind_list[index];
                }
                else
                {
                    return null;
                }
            }
            
        }
        public DBS.Menu m_menu_current
        {
            get {
                int index = listBox_Menu.SelectedIndex;
                if (index >= 0)
                {
                    return m_menu_list[index];
                }
                else
                {
                    return null;
                }
            }
        }
        public Main_Form()
        {
            InitializeComponent();
            h_kind_set();
            h_list_view_set();
        }
        public void h_kind_set()
        {
            m_kind_list = DBS.Kind.WHERE("status = '판매'");
            comboBox_Kind.Items.Clear();
            foreach(DBS.Kind e in m_kind_list)
            {
                comboBox_Kind.Items.Add(e.name);
            }
        }
        public void h_menu_set()
        {
            listBox_Menu.Items.Clear();
            if (m_kind_current != null)
            {
                m_menu_list = DBS.Menu.find_kind(m_kind_current.key);
                foreach (DBS.Menu e in m_menu_list)
                {
                    listBox_Menu.Items.Add(e.name);
                }
            }
        }

        private void comboBox_Kind_SelectedIndexChanged(object sender, EventArgs e)
        {
            h_menu_set();
        }

        private void 메뉴추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_Create_Form form = new Menu_Create_Form();
            if(m_kind_current !=null)
                form.h_kind_search(m_kind_current.key);
            form.ShowDialog();
            h_menu_set();
        }

        private void 추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kind_Create_From form = new Kind_Create_From();
            form.h_add();
            form.ShowDialog();
            h_kind_set();
        }

        private void 변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_kind_current != null)
            {
                Kind_Create_From form = new Kind_Create_From();
                form.h_change(m_kind_current);
                form.ShowDialog();
                h_kind_set();
            }
            else
            {
                MessageBox.Show("종류를 선택해주세요");
            }
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_kind_current != null)
            {
                m_kind_current.chage_status("절판");
                h_kind_set();
                h_menu_set();
            }
            else
            {
                MessageBox.Show("종류를 선택해주세요");
            }
        }

        private void 변경ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(m_menu_current==null)
            {
                MessageBox.Show("메뉴를 선택하세요");
            }
            else
            {

                Menu_Create_Form form = new Menu_Create_Form();
                form.h_change(m_menu_current);
                form.ShowDialog();
                h_menu_set();
            }
        }

        private void 삭제ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (m_menu_current != null)
            {
                m_menu_current.chage_status("절판");
                h_menu_set();
            }
            else
            {
                MessageBox.Show("메뉴를 선택해주세요");
            }
        }
        private void listBox_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void h_list_view_set()
        {
            listView_Sale_Menu.Columns.Add("메뉴",75);
            listView_Sale_Menu.Columns.Add("가격", 75);
            listView_Sale_Menu.Columns.Add("갯수", 75);
            listView_Sale_Menu.Columns.Add("총가격", 75);
            listView_Sale_Menu.View = View.Details;
        }
        public void h_sale_item_update()
        {
            listView_Sale_Menu.Items.Clear();
            int price = 0;
            foreach (DBS.Menu e in m_sale_menu_list)
            {
                bool triger = true;
                foreach(ListViewItem item_ in listView_Sale_Menu.Items )
                {
                    if(item_.SubItems[4].Text == Function.int2string(e.key))
                    {
                       int count =  Function.string2int(item_.SubItems[2].Text)+1;
                        item_.SubItems[2].Text = Function.int2string(count);
                        item_.SubItems[3].Text = Function.int2string(count * e.price);
                        triger = false;
                    }
                }
                if (triger)
                {
                    string price_ = Function.int2string(e.price);
                    string[] arg = new string[] {e.name, price_, "1", price_, Function.int2string(e.key) };
                    ListViewItem item = new ListViewItem(arg);
                    listView_Sale_Menu.Items.Add(item);
                }
                price += e.price;
            }
            textBox1.Text = Function.int2string(price);
        }
        private void button_Menu_Add_Click(object sender, EventArgs e)
        {
            if (m_menu_current != null)
            {
                DBS.Menu menu = new DBS.Menu(m_menu_current);
                m_sale_menu_list.Add(menu);
                h_sale_item_update();
            }
            else
            {
                MessageBox.Show("메뉴를 선택해 주세요");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                int menu_key = Function.string2int(listView_Sale_Menu.SelectedItems[0].SubItems[4].Text);
                foreach (DBS.Menu each in m_sale_menu_list)
                {
                    if (each.key == menu_key)
                    {
                        m_sale_menu_list.Remove(each);
                        break;
                    }
                }
                h_sale_item_update();
            }
            catch
            {
                MessageBox.Show("취소할 메뉴를 선택해주세요");
            }
        }

        private void button_Menu_Sale_Click(object sender, EventArgs e)
        {
            if (m_sale_menu_list.Count > 0)
            {
                DBS.Receipt receipt = new DBS.Receipt();
                receipt.id_key = DBS.ID.connect_id.key;
                receipt.status = "메뉴추가중";
                receipt.time = Function.time;
                receipt.save();
                int receipt_key = receipt.find_receipt2key();
                foreach (DBS.Menu each in m_sale_menu_list)
                {
                    DBS.Order order = new DBS.Order();
                    order.menu_key = each.key;
                    order.receipt_key = receipt_key;
                    order.status = "판매";
                    order.save();
                }
                receipt.key = receipt_key;
                receipt.chage_status("영수증");
                m_sale_menu_list = new List<DBS.Menu>();
                h_sale_item_update();
                MessageBox.Show("판매 완료");
            }
            else
            {
                MessageBox.Show("판매할 물건을 올려주세요");
            }
        }

        private void 월별사용자별ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics_Form form = new Statistics_Form();
            form.h_grid_update(0);
            form.ShowDialog();
        }

        private void 일일메뉴별ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics_Form form = new Statistics_Form();
            form.h_grid_update(1);
            form.ShowDialog();
        }

        private void 월별메뉴별ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics_Form form = new Statistics_Form();
            form.h_grid_update(2);
            form.ShowDialog();
        }

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Form.off = false;
            this.Close();
        }

        private void 로그인기록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log_Table_Form form = new Log_Table_Form();
            form.ShowDialog();
        }

        private void 변경ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Receipt_Setting_Form form = new Receipt_Setting_Form();
            form.ShowDialog();
        }
    }
}
