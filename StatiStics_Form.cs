using MySql.Data.MySqlClient;
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
    public partial class StatiStics_Form : Form
    {
        public StatiStics_Form()
        {
            InitializeComponent();
            comboBoxStatus.Items.Add("사용자별 일일");
            comboBoxStatus.Items.Add("종류별 일일");
            comboBoxStatus.Items.Add("종류별 월별");
        }
        public void h_user_view()
        {
            listView.Items.Clear();
            listView.Columns.Clear();
            listView.View = View.Details;
            listView.Columns.Add("아이디", 100, HorizontalAlignment.Left);
            listView.Columns.Add("일일 판매량", 100, HorizontalAlignment.Left);
            listView.Columns.Add("일일 판매액", 100, HorizontalAlignment.Left);
            List<string> idlist = new List<string>();
            using (MySqlConnection conn = new MySqlConnection(Function.con))
            {
                conn.Open();
                string query = string.Format
                    ("SELECT * FROM ID;");
                MySqlCommand findcommand = new MySqlCommand(query, conn);
                MySqlDataReader rdr = findcommand.ExecuteReader();
                while (rdr.Read())
                {
                    string id = (string)(rdr["id"]);
                    idlist.Add(id);
                }
                conn.Close();
            }
            foreach(string e in idlist)
            {
                using (MySqlConnection conn = new MySqlConnection(Function.con))
                {
                    conn.Open();
                    string query = string.Format
                        ("SELECT * FROM Receipt WHERE id='{0}' AND time LIKE '{1}%';",e,Function.date);
                    MySqlCommand findcommand = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = findcommand.ExecuteReader();
                    int count = 0;
                    int sales = 0;
                    while (rdr.Read())
                    {
                        int mn_key = (int)(rdr["mn_key"]);
                        count++;
                        sales += MenuList.h_key(mn_key).price;
                    }
                    ListViewItem item = new ListViewItem(e);
                    item.SubItems.Add(count.ToString());
                    item.SubItems.Add(sales.ToString());
                    listView.Items.Add(item);
                    conn.Close();
                }
            }
        }
        public void h_kinds_view()
        {
            listView.Items.Clear();
            listView.Columns.Clear();
            listView.View = View.Details;
            listView.Columns.Add("메뉴", 100, HorizontalAlignment.Left);
            listView.Columns.Add("일일 판매량", 100, HorizontalAlignment.Left);
            listView.Columns.Add("일일 판매액", 100, HorizontalAlignment.Left);

            List<MenuList> list = h_menulist_get();
            foreach(MenuList e in list)
            {
                using (MySqlConnection conn = new MySqlConnection(Function.con))
                {
                    conn.Open();
                    string query = string.Format
                        ("SELECT * FROM Receipt WHERE mn_key={0} AND time LIKE '%{1}%';", e.key,Function.date);
                    MySqlCommand findcommand = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = findcommand.ExecuteReader();
                    int count = 0;
                    int sales = 0;
                    while (rdr.Read())
                    {
                        count++;
                        sales += e.price;
                    }
                    ListViewItem item = new ListViewItem(e.name);
                    item.SubItems.Add(count.ToString());
                    item.SubItems.Add(sales.ToString());
                    listView.Items.Add(item);
                    conn.Close();
                }
            }
        }
        public void h_kinds_month_view()
        {
            listView.Items.Clear();
            listView.Columns.Clear();
            listView.View = View.Details;
            listView.Columns.Add("메뉴", 100, HorizontalAlignment.Left);
            listView.Columns.Add("월별 누적 판매량", 100, HorizontalAlignment.Left);
            listView.Columns.Add("월별 누적 판매액", 100, HorizontalAlignment.Left);

            List<MenuList> list = h_menulist_get();
            foreach (MenuList e in list)
            {
                using (MySqlConnection conn = new MySqlConnection(Function.con))
                {
                    conn.Open();
                    string query = string.Format
                        ("SELECT * FROM Receipt WHERE mn_key={0} AND time LIKE '%{1}%';", e.key, Function.month);
                    MySqlCommand findcommand = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = findcommand.ExecuteReader();
                    int count = 0;
                    int sales = 0;
                    while (rdr.Read())
                    {
                        int mn_key = (int)(rdr["mn_key"]);
                        count++;
                        sales += e.price;
                    }
                    ListViewItem item = new ListViewItem(e.name);
                    item.SubItems.Add(count.ToString());
                    item.SubItems.Add(sales.ToString());
                    listView.Items.Add(item);
                    conn.Close();
                }
            }
        }
        public List<MenuList> h_menulist_get()
        {
            List<MenuList> menulist = new List<MenuList>();
            using (MySqlConnection conn = new MySqlConnection(Function.con))
            {
                conn.Open();
                string query = string.Format
                    ("SELECT * FROM Menu;");
                MySqlCommand findcommand = new MySqlCommand(query, conn);
                MySqlDataReader rdr = findcommand.ExecuteReader();
                while (rdr.Read())
                {
                    int key = (int)(rdr["key"]);
                    menulist.Add(MenuList.h_key(key));
                }
                conn.Close();
            }
            return menulist;
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxStatus.SelectedIndex)
            {
                case 0:
                    h_user_view();
                    break;
                case 1:
                    h_kinds_view();
                    break;
                case 2:
                    h_kinds_month_view();
                    break;
            }
        }
    }
}
