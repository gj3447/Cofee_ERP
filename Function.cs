using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public static class Function
    {
        static public readonly string con = "Server=49.50.174.201;Database=s5414196;Uid=s5414196;Pwd=s5414196;Charset=utf8";
        public static int password(string data)
        {
            int result = 0;
            foreach(char e in data)
            {
                int a = e;
                a = a * a + data.Length;
                result = result + a;
            }
            result = result * result *result;
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
        static public string date
        {
            get
            {
                return System.DateTime.Now.ToString("yyyy/MM/dd");
            }
        }
        static public string month
        {
            get
            {
                return System.DateTime.Now.ToString("yyyy/MM/dd");
            }
        }
    }
}
