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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void buttonIDcreate_Click(object sender, EventArgs e)
        {
            IDcreate_Form form = new IDcreate_Form();
            form.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Function.con))
            {
                conn.Open();
                string id = textBoxID.Text;
                int password = Function.password(textBoxPassWord.Text);
                string findquery = string.Format
                    ("SELECT * FROM ID WHERE id='{0}';", id);
                MySqlCommand findcommand = new MySqlCommand(findquery, conn);
                MySqlDataReader rdr = findcommand.ExecuteReader();
                if (rdr.Read())
                {
                    if((int)rdr["password"]==password)
                    {
                        MessageBox.Show("로그인 성공");
                        this.Visible = false;
                        Casher_Form form = new Casher_Form();
                        form.h_login(id);
                        form.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 틀렷습니다");
                    }
                }
                else
                {
                    MessageBox.Show("아이디가 없습니다");
                }
            }
        }
    }
}
