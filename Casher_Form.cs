using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class Casher_Form : Form
    {
        Clock m_clock;
        string m_id;
        int m_sales;
        public void h_login(string id)
        {
            m_id = id;
            labelID.Text =  string.Format("ID : {0}",id);
        }
        public void h_sales_update()
        {
            labelSales.Text = string.Format("sales : {0} ",m_sales.ToString());
        }
        public Casher_Form()
        {
            InitializeComponent();
            h_start();
            h_menuupdate();
            h_sales_update();
            m_clock = new Clock(labelClock,this);
        }
        private void h_start()
        {

            listViewMenu.View = View.Details;
            listViewMenu.Columns.Add("번호", 50, HorizontalAlignment.Left);
            listViewMenu.Columns.Add("이름", 50, HorizontalAlignment.Left);
            listViewMenu.Columns.Add("종류", 50, HorizontalAlignment.Left);
            listViewMenu.Columns.Add("가격", 50, HorizontalAlignment.Left);
        }
        public void h_menuupdate()
        {
            listViewMenu.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(Function.con))
            {
                conn.Open();
                string query = string.Format
                    ("SELECT * FROM Menu;");
                MySqlCommand findcommand = new MySqlCommand(query, conn);
                MySqlDataReader rdr = findcommand.ExecuteReader();
                while (rdr.Read())
                {
                    string name = ((string)rdr["name"]);
                    string kinds = ((string)rdr["kinds"]);
                    int key = ((int)rdr["key"]);
                    int price = ((int)rdr["price"]);
                    ListViewItem item = new ListViewItem(key.ToString());
                    item.SubItems.Add(name);
                    item.SubItems.Add(kinds);
                    item.SubItems.Add(price.ToString());
                    listViewMenu.Items.Add(item);
                }
                conn.Close();
            }
        }
        private void buttonMenuAdd_Click(object sender, EventArgs e)
        {
            Menucreate_Form form = new Menucreate_Form();
            form.m_form = this;
            form.Show();
        }

        private void Casher_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_clock.h_stop();
        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            string key = "";
            if (listViewMenu.SelectedItems.Count != 0)
            {
                int SelectRow = listViewMenu.SelectedItems[0].Index;

                key = listViewMenu.Items[SelectRow].SubItems[0].Text;
            }
            else
            {
                MessageBox.Show("메뉴를 선택해주세요");
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(Function.con))
            {
                conn.Open();
                string insertquery = string.Format
                    ("INSERT INTO Receipt(mn_key,status,time,id) VALUES({0},'{1}','{2}','{3}');",key,"판매",Function.time,m_id);
                MySqlCommand insertcommand = new MySqlCommand(insertquery, conn);
                Console.WriteLine(insertquery);
                if (insertcommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(string.Format("판매를 완료하엿습니다"));
                    m_sales += MenuList.h_key(Function.string2int(key)).price;
                    h_sales_update();
                }
                conn.Close();
            }
        }

        private void buttonStatiStics_Click(object sender, EventArgs e)
        {
            StatiStics_Form form = new StatiStics_Form();
            form.Show();
        }
    }
}
