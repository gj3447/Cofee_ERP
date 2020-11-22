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
        public static bool off;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button_IDCreate_Click(object sender, EventArgs e)
        {
            ID_Create_Form form = new ID_Create_Form();
            form.Show();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string s_id = textBox_ID.Text;
            string s_password = textBox_PassWord.Text;
            DBS.ID d_id = DBS.ID.find_id(s_id);
            if(d_id ==null)
            {
                MessageBox.Show("아이디가 없습니다");
            }
            else
            {
                if(d_id.password == Function.encryptAES128(s_password))
                {
                    MessageBox.Show("로그인 성공");
                    DBS.ID.connect_id = d_id;
                    Main_Form form = new Main_Form();
                    off = true;
                    this.Visible = false;
                    form.ShowDialog();
                    DBS.ID.connect_id = null;
                    if (off)
                        this.Close();
                    else
                        this.Visible = true;
                }
                else
                {
                    MessageBox.Show("비밀번호가 틀렷습니다");
                }
            }
        }
    }
}
