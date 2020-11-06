using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class IDcreate_Form : Form
    {
        public IDcreate_Form()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Function.con))
            {
                conn.Open();
                string id = textBoxID.Text;
                int password = Function.password(textBoxPassWord.Text);
                string findquery = string.Format
                    ("SELECT id FROM ID WHERE id='{0}';", id);
                MySqlCommand findcommand = new MySqlCommand(findquery, conn);
                MySqlDataReader rdr = findcommand.ExecuteReader();
                if(rdr.Read())
                {
                    MessageBox.Show("이미 존재하는 아이디입니다");
                    return;
                }
                conn.Close();
                conn.Open();
                string insertquery = string.Format
                    ("INSERT INTO ID(id,password) VALUES('{0}',{1});",id,password);
                MySqlCommand insertcommand = new MySqlCommand(insertquery, conn);
                Console.WriteLine(insertquery);
                if(insertcommand.ExecuteNonQuery() ==1)
                {
                    MessageBox.Show(string.Format("'{0}' 아이디가 성공적으로 만들어졋습니다", id));
                }
                conn.Close();
                Close();
            }
        }
    }
}
