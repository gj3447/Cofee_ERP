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
    public partial class Menucreate_Form : Form
    {
        public Casher_Form m_form;
        public Menucreate_Form()
        {
            InitializeComponent();
            h_kindupdate();
        }

        private void h_kindupdate()
        {
            int index = comboBoxKinds.SelectedIndex;
            comboBoxKinds.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(Function.con))
            {
                conn.Open();
                string query = string.Format
                    ("SELECT * FROM Kinds ;");
                MySqlCommand findcommand = new MySqlCommand(query, conn);
                MySqlDataReader rdr = findcommand.ExecuteReader();
                while(rdr.Read())
                {
                    comboBoxKinds.Items.Add((string)rdr["name"]);
                }
                if(comboBoxKinds.Items.Count>index)
                {
                    comboBoxKinds.SelectedIndex = index;
                }
                conn.Close();
            }
        }
        private void buttonKindsAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Function.con))
            {
                conn.Open();
                string kindname = textBoxKindsAdd.Text;
                string findquery = string.Format
                    ("SELECT * FROM Kinds WHERE name='{0}';", kindname);
                MySqlCommand findcommand = new MySqlCommand(findquery, conn);
                MySqlDataReader rdr = findcommand.ExecuteReader();
                if (rdr.Read())
                {
                    MessageBox.Show("이미 존재하는 종류입니다");
                    return;
                }
                conn.Close();
                conn.Open();
                string insertquery = string.Format
                    ("INSERT INTO Kinds(name) VALUES('{0}');", kindname);
                MySqlCommand insertcommand = new MySqlCommand(insertquery, conn);
                Console.WriteLine(insertquery);
                if (insertcommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(string.Format("'{0}' 가 성공적으로 만들어졋습니다", kindname));
                }
                h_kindupdate();
                conn.Close();
            }
        }

        private void buttonMenuAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxKinds.SelectedIndex >= 0&&textBoxMenuName.Text!="")
            {
                using (MySqlConnection conn = new MySqlConnection(Function.con))
                {
                    conn.Open();
                    string menuname = textBoxMenuName.Text;
                    string kindname = comboBoxKinds.SelectedItem.ToString();
                    int price = Function.string2int(textBoxMenuPrice.Text);

                    string insertquery = string.Format
                        ("INSERT INTO Menu(name,price,kinds) VALUES('{0}',{1},'{2}');",menuname,price, kindname);
                    MySqlCommand insertcommand = new MySqlCommand(insertquery, conn);
                    Console.WriteLine(insertquery);
                    if (insertcommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show(string.Format("'{0}' 가 성공적으로 만들어졋습니다", menuname));
                    }
                    conn.Close();
                    m_form.h_menuupdate();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("필드를 입력하시오");
            }
        }
    }
}
