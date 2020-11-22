using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    class Login
    {
        public string m_id;
        public Login(string id)
        {
            MessageBox.Show("로그인 성공함");
            m_id = id;
            using (MySqlConnection conn = new MySqlConnection(Function.con))
            {
                conn.Open();
                string insertquery = string.Format
                    ("INSERT INTO Login(id,time,status) VALUES('{0}','{1}','로그인');", m_id,Function.time);
                MySqlCommand insertcommand = new MySqlCommand(insertquery, conn);
                insertcommand.ExecuteNonQuery();
                conn.Close();
            }
        }
        ~Login()
        {
        }
        public void h_logout()
        {
            using (MySqlConnection conn = new MySqlConnection(Function.con))
            {
                conn.Open();
                string insertquery = string.Format
                    ("INSERT INTO Login(id,time,status) VALUES('{0}','{1}','로그아웃');", m_id, Function.time);
                MySqlCommand insertcommand = new MySqlCommand(insertquery, conn);
                insertcommand.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
