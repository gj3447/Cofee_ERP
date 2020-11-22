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
    public partial class Receipt_Setting_Form : Form
    {
        List<DBS.Receipt> m_receipt_list;
        List<DBS.Order> m_order_list;
        DBS.Receipt m_receipt_current { 
            get{
                if (listBox_Receipt.SelectedIndex < 0)
                    return null;
                else
                {
                    return m_receipt_list[listBox_Receipt.SelectedIndex];
                }}}
        DBS.Order m_order_current{
            get{
                if (listBox_Order.SelectedIndex < 0)
                    return null;
                else
                {
                    return m_order_list[listBox_Order.SelectedIndex];
                }}}
        public Receipt_Setting_Form()
        {
            InitializeComponent();
            h_search();
        }
        public void h_search()
        {
            m_receipt_list = new List<DBS.Receipt>();
            m_order_list = new List<DBS.Order>();
            listBox_Order.Items.Clear();
            listBox_Receipt.Items.Clear();
            string time  = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            List<DBS.Receipt> receipts = DBS.Receipt.find_time_id(time,DBS.ID.connect_id.key);
            foreach(DBS.Receipt e in receipts)
            {
                string[] stemp = e.time.Split(' ');
                string[] stemp_ = stemp[1].Split(':');
                int hour = Function.string2int(stemp_[0]);
                int minite = Function.string2int(stemp_[1]);
                int after_hour = Function.string2int(textBox_After_Hour.Text);
                int after_minite = Function.string2int(textBox_After_Minite.Text);
                int before_hour = Function.string2int(textBox_Before_Hour.Text);
                int before_minite = Function.string2int(textBox_Before_Minite.Text);
                if (hour < after_hour && before_hour < hour)
                {
                    m_receipt_list.Add(e);
                    listBox_Receipt.Items.Add(e.time);
                }
                else if(minite <= after_minite && before_minite<=minite)
                {
                    m_receipt_list.Add(e);
                    listBox_Receipt.Items.Add(e.time);
                }
            }
        }
        public void h_order_add()
        {
            listBox_Order.Items.Clear();
            if (m_receipt_current!=null)
            {
                List<DBS.Order> orders = DBS.Order.find_receipt(m_receipt_current.key);
                List<DBS.Order> order__ = new List<DBS.Order>();
                foreach(DBS.Order e in orders)
                {
                        listBox_Order.Items.Add(DBS.Menu.find(e.menu_key).name);
                        order__.Add(e);
                }
                m_order_list = order__;
            }
        }
        private void button_Search_Click(object sender, EventArgs e)
        {
            h_search();
        }

        private void listBox_Receipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            h_order_add();
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            if(m_order_current==null)
            {
                Console.WriteLine("반품할 메뉴를 정해주세요");
            }
            else
            {
                m_order_current.chage_status("반품");
                textBox_Status.Text = "반품";
            }
            h_order_add();
        }

        private void listBox_Order_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(m_order_current==null)
            {
                textBox_Status.Text = "";
            }
            else
            {
                textBox_Status.Text = m_order_current.status;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m_order_current == null)
            {
                Console.WriteLine("반품할 메뉴를 정해주세요");
            }
            else
            {
                m_order_current.chage_status("판매");
                textBox_Status.Text = "판매";
            }
            h_order_add();
        }
    }
}
