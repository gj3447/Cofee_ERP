using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public static class Function
    {
        static public readonly string con = "Server=49.50.174.201;Database=s5414196;Uid=s5414196;Pwd=s5414196;Charset=utf8";
        static private readonly string KEY = "01234567890123456789012345678901";
        static private readonly string KEY_128 = KEY.Substring(0, 128 / 8);
        static private readonly string KEY_256 = KEY.Substring(0, 256 / 8);
        public static string encryptAES128(string plain)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plain);

            RijndaelManaged rm = new RijndaelManaged();
            rm.Mode = CipherMode.CBC;
            rm.Padding = PaddingMode.PKCS7;
            rm.KeySize = 128;

            MemoryStream memoryStream = new MemoryStream();
            ICryptoTransform encryptor = rm.CreateEncryptor(Encoding.UTF8.GetBytes(KEY_128), Encoding.UTF8.GetBytes(KEY_128));
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);

            cryptoStream.Write(plainBytes, 0, plainBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] encryptBytes = memoryStream.ToArray();

            string encryptString = Convert.ToBase64String(encryptBytes);

            cryptoStream.Close();
            memoryStream.Close();

            return encryptString;
        }
        static public string int2string(int data)
        {
            int digit = 1;
            string result = "";
            for(digit = 1; digit<=data;digit*=10)
            {
                int itemp = data / digit;
                itemp = itemp % 10;
                itemp += 48;
                char ctemp = (char)itemp;
                result = string.Format("{0}{1}", ctemp, result);
            }
            return result;
        }
        static public int string2int(string data)
        {
            string stemp = "";
            foreach(char e in data)
            {
                if(e<='9'&&e>='0')
                {
                    stemp += e;
                }
            }
            stemp = string_reverse(stemp);
            int result = 0;
            int digit = 1;
            foreach(char e in stemp)
            {
                result += (int)(e - 48) * digit;
                digit *= 10;
            }
            return result;
        }
        static public string string_reverse(string data)
        {
            string result = "";
            for(int i = data.Length-1;i>=0;i--)
            {
                result += data[i];
            }
            return result;
        }
        static public string time
        {
            get
            {
                return System.DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            }
        }
        static public string string_arg(string[] data, string between)
        {
            if (data.Length > 0)
            {
                string result = data[0];
                for(int i = 1; i<data.Length;i++)
                {
                    result = string.Format("{0}{1}{2}", result,between, data[i]);
                }
                return result;
            }
                else
                        return "";
        }
        static private MySqlConnection conn_value = null;
        static public MySqlConnection conn
        {
            get {
                if(conn_value !=null)
                    conn_value.Close();
                conn_value = new MySqlConnection(con);
                conn_value.Open();
                return conn_value;
            }
        }
    }
}
