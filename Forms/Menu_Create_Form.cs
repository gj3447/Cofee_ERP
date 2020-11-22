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
    public partial class Menu_Create_Form : Form
    {
        List<DBS.Kind> m_kind_list;
        DBS.Menu m_change_menu;
        public Menu_Create_Form()
        {
            InitializeComponent();
            h_kind_set();
            m_change_menu = null;
        }
        public void h_kind_set()
        {
            m_kind_list = DBS.Kind.WHERE("status = '판매'");
            foreach(DBS.Kind e in m_kind_list)
            {
                comboBox_Kind.Items.Add(e.name);
            }
        }
        public void h_change(DBS.Menu menu)
        {
            textBox_Name.Text = menu.name;
            textBox_Price.Text = Function.int2string(menu.price);
            h_kind_search(menu.kind_key);
            button_Update.Text = "변경";
            m_change_menu = menu;
        }
        public void h_kind_search(int kind_key)
        {
            for (int i = 0; i < m_kind_list.Count; i++)
            {
                if (m_kind_list[i].key == kind_key)
                {
                    comboBox_Kind.SelectedIndex = i;
                }
            }
        }
        private void button_Update_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "")
                MessageBox.Show("메뉴 이름을 입력하세요");
            if (comboBox_Kind.SelectedIndex < 0)
                MessageBox.Show("종류를 선택하세요");
            DBS.Menu menu = new DBS.Menu();
            menu.name = textBox_Name.Text;
            menu.price = Function.string2int(textBox_Price.Text);
            menu.kind_key = m_kind_list[comboBox_Kind.SelectedIndex].key;
            menu.status = "판매";
            menu.save();
            if(m_change_menu!=null)
            {
                m_change_menu.chage_status("절판");
            }
            Close();
        }
    }
}
