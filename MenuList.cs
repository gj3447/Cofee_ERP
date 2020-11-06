using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class MenuList
    {
        public int key;
        public string name;
        public int price;
        public string kinds;
        public static MenuList h_key(int key_)
        {
            MenuList menu = new MenuList();
            using (MySqlConnection conn = new MySqlConnection(Function.con))
            {
                conn.Open();

                string query = string.Format("SELECT * from Menu");
                Console.WriteLine(query);
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader rdr = command.ExecuteReader();
                while(rdr.Read())
                {
                    if ((int)(rdr["key"]) == key_)
                    {
                        menu.name = (string)(rdr["name"]);
                        menu.price = (int)(rdr["price"]);
                        menu.kinds = (string)(rdr["kinds"]);
                        menu.key = key_;
                        conn.Close();
                        return menu;
                    }
                }
            }
            return null;
        }
    }
}
