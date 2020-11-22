using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public static class DBS
    {
        public class Table
        {
            public static string table_name;
        }
        public class ID : Table
        {
            public int key;
            public string id;
            public string password;
            public ID(MySqlDataReader rdr)
            {
                key = (int)(rdr["key"]);
                id = (string)(rdr["ID"]);
                password = (string)(rdr["password"]);
            }
            public ID()
            {
            }
            public static List<ID> list
            {
                get
                {
                    List<ID> result = new List<ID>();
                    string query = "SELECT * FROM ID";
                    MySqlCommand command = new MySqlCommand(query, Function.conn);
                    MySqlDataReader rdr = command.ExecuteReader();
                    while(rdr.Read())
                    {
                        result.Add(new ID(rdr));
                    }
                    return result;
                }
            }
            public static ID find(int key)
            {
                string query = string.Format("SELECT * FROM ID WHERE ID.key = '{0}'", key);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                MySqlDataReader rdr = command.ExecuteReader();
                if (rdr.Read())
                {
                    return new ID(rdr);
                }
                else
                {
                    Console.WriteLine("아이디 키가 없습니다");
                    return null;
                }
            }
            public static ID find_id(string id)
            {
                string query = string.Format("SELECT * FROM ID WHERE id = '{0}'", id);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                MySqlDataReader rdr = command.ExecuteReader();
                if(rdr.Read())
                {
                    return new ID(rdr);
                }
                else
                {
                    Console.WriteLine("아이디가 없습니다");
                    return null;
                }
            }
            public void save()
            {
                string query = string.Format("INSERT INTO ID(id,password) VALUES('{0}','{1}')", id, password);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                command.ExecuteNonQuery();
            }
            public bool overlap()
            {
                string query= string.Format("SELECT * FROM ID WHERE id = '{0}'", id);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                MySqlDataReader rdr = command.ExecuteReader();
                return rdr.Read();
            }
            private static ID connect_id_value;
            public static ID connect_id
            {
                get { return connect_id_value; }
                set {
                    if (value ==null)
                    {
                        Login login = new Login();
                        login.id_key = connect_id_value.key;
                        login.status = "로그아웃";
                        login.time = Function.time;
                        login.save();
                        connect_id_value = null;
                    }
                    else
                    {
                        connect_id_value = value;
                        Login login = new Login();
                        login.id_key = connect_id_value.key;
                        login.status = "로그인";
                        login.time = Function.time;
                        login.save();
                    }
                }
            }
        }
        public class Login : Table
        {
            public int key;
            public int id_key;
            public string time;
            public string status;
            public Login(MySqlDataReader rdr)
            {
                key = (int)(rdr["key"]);
                id_key = (int)(rdr["id_key"]);
                time = (string)(rdr["time"]);
                status = (string)(rdr["status"]);
            }
            public Login()
            { }
            public static List<Login> list
            {
                get
                {
                    List<Login> result = new List<Login>();
                    string query = "SELECT * FROM Login";
                    MySqlCommand command = new MySqlCommand(query, Function.conn);
                    MySqlDataReader rdr = command.ExecuteReader();
                    while(rdr.Read())
                    {
                        result.Add(new Login(rdr));
                    }
                    return result;
                }
            }
            public static Login find(int key)
            {
                string query = string.Format("SELECT * FROM Login WHERE key = {0}", key);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                MySqlDataReader rdr = command.ExecuteReader();
                if (rdr.Read())
                {
                    return new Login(rdr);
                }
                else
                {
                    Console.WriteLine("로그인 키값이 없습니다");
                    return null;
                }
            }
            public void save()
            {
                string query = string.Format("INSERT INTO Login(id_key,time,status) VALUES('{0}','{1}','{2}')", id_key, time , status);
                
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                command.ExecuteNonQuery();
            }
        }
        public class Menu : Table
        {
            public int key;
            public string name;
            public int price;
            public int kind_key;
            public string status;
            public int m_count;
            public Menu(MySqlDataReader rdr)
            {
                key = (int)(rdr["key"]);
                name = (string)(rdr["name"]);
                price = (int)(rdr["price"]);
                kind_key = (int)(rdr["kind_key"]);
                status = (string)(rdr["status"]);
            }
            public Menu()
            { }
            public Menu(Menu menu)
            {
                key = menu.key;
                name = menu.name;
                price = menu.price;
                kind_key = menu.kind_key;
                status = menu.status;
            }
            public static List<Menu> list
            {
                get
                {
                    List<Menu> result = new List<Menu>();
                    string query = "SELECT * FROM Menu";
                    MySqlCommand command = new MySqlCommand(query, Function.conn);
                    MySqlDataReader rdr = command.ExecuteReader();
                    while(rdr.Read())
                    {
                        result.Add(new Menu(rdr));
                    }
                    return result;
                }
            }
            public static Menu find(int key)
            {
                string query = string.Format("SELECT * FROM Menu WHERE Menu.key = '{0}'", key);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                MySqlDataReader rdr = command.ExecuteReader();
                if(rdr.Read())
                {
                    return new Menu(rdr);
                }
                else
                {
                    Console.WriteLine("메뉴 키가 없습니다");
                    return null;
                }
            }
            public static List<Menu> find_kind(int kind_key)
            {
                List<Menu> result = new List<Menu>();
                string query = string.Format("SELECT * FROM Menu WHERE kind_key = {0} AND status = '판매'", kind_key);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                MySqlDataReader rdr = command.ExecuteReader();
                while(rdr.Read())
                {
                    result.Add(new Menu(rdr));
                }
                return result;
            }
            public void chage_status(string status)
            {
                string query = string.Format("UPDATE `s5414196`.`Menu` SET `status` = '{0}' WHERE(`key` = '{1}'); ", status, key);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                command.ExecuteNonQuery();
            }
            public void save()
            {
                string query = string.Format("INSERT INTO Menu(name,price,kind_key,status) VALUES('{0}','{1}','{2}','{3}')", name, price, kind_key, status);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                command.ExecuteNonQuery();
            }
        }
        public class Kind : Table
        {
            public int key;
            public string name;
            public string status;
            public Kind()
            {
                table_name = "Kind";
            }
            public Kind(MySqlDataReader rdr)
            {
                key = (int)(rdr["key"]);
                name = (string)(rdr["name"]);
                status = (string)(rdr["status"]);
            }
            public static List<Kind> list
            {
                get
                {
                    List<Kind> result = new List<Kind>();
                    string query = "SELECT * FROM Kind;";
                    MySqlCommand command = new MySqlCommand(query, Function.conn);
                    MySqlDataReader rdr = command.ExecuteReader();
                    while(rdr.Read())
                    {
                        result.Add(new Kind(rdr));
                    }
                    return result;
                }
            }
            public static List<Kind> WHERE(string where)
            {
                List<Kind> result = new List<Kind>();
                string query = string.Format("SELECT * FROM Kind WHERE {0};",where);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                MySqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    result.Add(new Kind(rdr));
                }
                return result;
            }
            public static Kind find(int key)
            {
                string query = string.Format("SELECT * FROM Kind WHERE key = {0}", key);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                MySqlDataReader rdr = command.ExecuteReader();
                if(rdr.Read())
                {
                    return new Kind(rdr);
                }
                else
                {
                    Console.WriteLine("종류 키가 없습니다");
                    return null;
                }
            }
            public void chage_name(string name)
            {
                string query = string.Format("UPDATE `s5414196`.`Kind` SET `name` = '{0}' WHERE (`key` = '{1}');", name, key);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                command.ExecuteNonQuery();
            }
            public void chage_status(string status)
            {
                string query = string.Format("UPDATE `s5414196`.`Kind` SET `status` = '{0}' WHERE(`key` = '{1}'); ", status, key);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                command.ExecuteNonQuery();
            }
            public void delete()
            {
                string query = string.Format("DELETE FROM `s5414196`.`Kind` WHERE (`key` = '{0}')", key);
                MessageBox.Show(query);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                command.ExecuteNonQuery();
            }
            public void save()
            {
                string query = string.Format("INSERT INTO Kind(name,status) VALUES('{0}','{1}')", name,status);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                command.ExecuteNonQuery();
            }
        }
        public class Receipt : Table
        {
            public int key;
            public string time;
            public int id_key;
            public string status;
            public Receipt()
            { }
            public Receipt(MySqlDataReader rdr)
            {
                key = (int)rdr["key"];
                time = (string)rdr["time"];
                id_key = (int)rdr["id_key"];
            }
            public void chage_status(string status)
            {
                string query = string.Format("UPDATE `s5414196`.`Receipt` SET `status` = '{0}' WHERE(`key` = '{1}'); ", status, key);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                command.ExecuteNonQuery();
            }
            public static List<Receipt> find_time_id(string time, int id_key)
            {
                List<Receipt> result = new List<Receipt>();
                string query = string.Format("SELECT * FROM Receipt WHERE time LIKE '%{0}%' AND id_key = '{1}'", time,id_key);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                MySqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    result.Add(new Receipt(rdr));
                }
                return result;
            }
            public static List<Receipt> list
            {
                get
                {
                    List<Receipt> result = new List<Receipt>();
                    string query = "SELECT * FROM Receipt";
                    MySqlCommand command = new MySqlCommand(query, Function.conn);
                    MySqlDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        result.Add(new Receipt(rdr));
                    }
                    return result;
                }
            }
            public static List<Receipt> find_time(string time)
            {
                List<Receipt> result = new List<Receipt>();
                string query = string.Format("SELECT * FROM Receipt WHERE time LIKE '%{0}%'", time);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                MySqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    result.Add(new Receipt(rdr));
                }
                return result;
            }
            public int find_receipt2key()
            {
                string query = string.Format("SELECT * FROM Receipt WHERE time = '{0}' AND id_key = '{1}' AND status = '{2}'", time, id_key, status);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                MySqlDataReader rdr = command.ExecuteReader();
                if (rdr.Read())
                {
                    Receipt result = new Receipt(rdr);
                    return result.key;
                }
                else
                    return 1;
            }
            public static Receipt find(int key)
            {
                string query = string.Format("SELECT * FROM Receipt WHERE key = {0}", key);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                MySqlDataReader rdr = command.ExecuteReader();
                if (rdr.Read())
                {
                    return new Receipt(rdr);
                }
                else
                {
                    Console.WriteLine("명세서 키가 없습니다");
                    return null;
                }
            }
            public void save()
            {
                string query = string.Format("INSERT INTO Receipt(time,id_key,status) VALUES ('{0}','{1}','{2}')", time, id_key,status);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                command.ExecuteNonQuery();
            }
        }
        public class Order
        {
            public int key;
            public string status;
            public int menu_key;
            public int receipt_key;
            public Order()
            {

            }
            public Order(MySqlDataReader rdr)
            {
                key = (int)rdr["key"];
                status = (string)rdr["status"];
                menu_key = (int)rdr["menu_key"];
                receipt_key = (int)rdr["receipt_key"];
            }
            public static List<Order> find_receipt(int key)
            {
                List<Order> result = new List<Order>();
                string query = string.Format("SELECT * FROM s5414196.Order WHERE receipt_key = '{0}'", key);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                MySqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    result.Add(new Order(rdr));
                }
                return result;
            }
            public void save()
            {
                string query = string.Format("INSERT INTO `s5414196`.`Order` (`status`, `receipt_key`, `menu_key`) VALUES ('{0}', '{1}', '{2}');", status, receipt_key,menu_key);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                command.ExecuteNonQuery();
            }
            public void chage_status(string status)
            {
                string query = string.Format("UPDATE `s5414196`.`Order` SET `status` = '{0}' WHERE(`key` = '{1}'); ", status, key);
                MySqlCommand command = new MySqlCommand(query, Function.conn);
                command.ExecuteNonQuery();
            }
        }
    }
}