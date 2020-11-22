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
    public partial class Statistics_Form : Form
    {
        public Statistics_Form()
        {
            InitializeComponent();
        }

        private void button_LookUp_Click(object sender, EventArgs e)
        {
            h_grid_update(comboBox_type.SelectedIndex);
        }
        public void h_grid_update(int i)
        {
            comboBox_type.SelectedIndex = i;
            switch (i)
            {
                case 0:
                    {
                        h_user_date();
                        break;
                    }
                case 1:
                    {
                        h_menu_date();
                        break;
                    }
                case 2:
                    {
                        h_menu_month();
                        break;
                    }
            }
        }
        public void h_user_date()
        {
            string time = dateTimePicker.Value.ToString("yyyy/MM/dd");
            List<DBS.Receipt> receipt_list = DBS.Receipt.find_time(time);

            List<int> id_key_list = new List<int>();
            List<List<DBS.Receipt>> id2receipt_list = new List<List<DBS.Receipt>>();
            foreach(DBS.Receipt e in receipt_list)
            {
                bool triger = true;
                for(int i = 0; i<id_key_list.Count;i++)
                {
                    if(id_key_list[i] == e.id_key)
                    {
                        triger = false;
                        id2receipt_list[i].Add(e);
                    }
                }
                if(triger)
                {
                    id_key_list.Add(e.id_key);
                    List<DBS.Receipt> receipts = new List<DBS.Receipt>();
                    receipts.Add(e);
                    id2receipt_list.Add(receipts);
                }
            }
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("ID", typeof(string)));
            table.Columns.Add(new DataColumn("판매수", typeof(float)));
            table.Columns.Add(new DataColumn("판매가격", typeof(float)));
            for(int i = 0;i<id_key_list.Count;i++)
            {
                DataRow row = table.NewRow();
                int count__ = 0;
                int price__ = 0;
                foreach(DBS.Receipt e in id2receipt_list[i])
                {
                    List<DBS.Order> list = DBS.Order.find_receipt(e.key);
                    foreach(DBS.Order a in list)
                    {
                        if (a.status == "판매")
                        {
                            count__ += 1;
                            price__ += DBS.Menu.find(a.menu_key).price;
                        }
                    }
                }
                row["ID"] = DBS.ID.find(id_key_list[i]).id;
                row["판매수"] = count__;
                row["판매가격"] = price__;
                table.Rows.Add(row);
            }
            dataGridView.DataSource = table;
        }
        public void h_menu_month()
        {
            string time = dateTimePicker.Value.ToString("yyyy/MM");
            List<DBS.Receipt> receipt_list = DBS.Receipt.find_time(time);
            List<int> menu_key_list = new List<int>();

            List<List<DBS.Order>> menu2order_list = new List<List<DBS.Order>>();
            foreach (DBS.Receipt e in receipt_list)
            {
                foreach (DBS.Order a in DBS.Order.find_receipt(e.key))
                {
                    if (a.status == "판매")
                    {
                        bool triger = true;
                        for (int i = 0; i < menu_key_list.Count; i++)
                        {
                            if (menu_key_list[i] == a.menu_key)
                            {
                                menu2order_list[i].Add(a);
                                triger = false;
                            }
                        }
                        if (triger)
                        {
                            menu_key_list.Add(a.menu_key);
                            List<DBS.Order> orders = new List<DBS.Order>();
                            orders.Add(a);
                            menu2order_list.Add(orders);
                        }
                    }
                }
            }
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("메뉴 이름", typeof(string)));
            table.Columns.Add(new DataColumn("판매수", typeof(float)));
            table.Columns.Add(new DataColumn("판매가격", typeof(float)));
            for (int i = 0; i < menu_key_list.Count; i++)
            {
                DataRow row = table.NewRow();
                DBS.Menu menu = DBS.Menu.find(menu_key_list[i]);
                int count__ = menu2order_list[i].Count;
                int price__ = count__ * menu.price;

                row["메뉴 이름"] = menu.name;
                row["판매수"] = count__;
                row["판매가격"] = price__;
                table.Rows.Add(row);
            }
            dataGridView.DataSource = table;
        }
        public void h_menu_date()
        {
            string time = dateTimePicker.Value.ToString("yyyy/MM/dd");
            List<DBS.Receipt> receipt_list = DBS.Receipt.find_time(time);
            List<int> menu_key_list = new List<int>();

            List<List<DBS.Order>> menu2order_list = new List<List<DBS.Order>>();
            foreach (DBS.Receipt e in receipt_list)
            {
                foreach(DBS.Order a in DBS.Order.find_receipt(e.key))
                {
                    if (a.status == "판매")
                    {
                        bool triger = true;
                        for (int i = 0; i < menu_key_list.Count; i++)
                        {
                            if (menu_key_list[i] == a.menu_key)
                            {
                                menu2order_list[i].Add(a);
                                triger = false;
                            }
                        }
                        if (triger)
                        {
                            menu_key_list.Add(a.menu_key);
                            List<DBS.Order> orders = new List<DBS.Order>();
                            orders.Add(a);
                            menu2order_list.Add(orders);
                        }
                    }
                }
            }
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("메뉴 이름", typeof(string)));
            table.Columns.Add(new DataColumn("판매수", typeof(float)));
            table.Columns.Add(new DataColumn("판매가격", typeof(float)));
            for (int i = 0; i < menu_key_list.Count; i++)
            {
                DataRow row = table.NewRow();
                DBS.Menu menu = DBS.Menu.find(menu_key_list[i]);
                int count__ = menu2order_list[i].Count;
                int price__ = count__ * menu.price;

                row["메뉴 이름"] = menu.name;
                row["판매수"] = count__;
                row["판매가격"] = price__;
                table.Rows.Add(row);
            }
            dataGridView.DataSource = table;
        }
    }
}