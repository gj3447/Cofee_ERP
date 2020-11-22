using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    class Query
    {
        public Query()
        {
        }
        public string[] query = {"","","","","","","","","","","",";"};
        public Query SELECT(string data)
        {
            query[0] = string.Format("SELECT {0}", data);
            return this;
        }
        public Query SELECT(string[] column)
        {
            string data = Function.string_arg(column, ",");
            return SELECT(data);
        }
        public Query SELECT()
        {
            return SELECT("*");
        }
        public Query FROM(string table)
        {
            query[1] = string.Format("FROM {0}", table);
            return this;
        }
        public Query WHERE(string data)
        {
            query[4] = string.Format("WHERE {0}", data);
            return this;
        }
        public Query JOIN(string data)
        {
            query[2] = string.Format("JOIN {0}", data);
            return this;
        }
        public Query ON(string data)
        {
            query[3] = string.Format("ON ({0})", data);
            return this;
        }
        #region insert
        public Query INSERT(string table)
        {
            query[0] = string.Format("INSERT INTO {0}", table);
            return this;
        }
        public Query INTO(string data)
        {
            query[1] = string.Format("");
            return this;
        }
        public Query INTO(string[] column)
        {
            string data = string.Format("({0})", Function.string_arg(column,","));
            return INTO(data);
        }
        public Query VALUES(string data)
        {
            query[2] = string.Format("VALUES {0}", data);
            return this;
        }
        public Query VALUES(string[] column)
        {
            string data = string.Format("({0})", Function.string_arg(column,","));
            return VALUES(data);
        }
        #endregion
        public string QUERY {
            get {
                string result = Function.string_arg(query, "");
                return result;
            }
        }
        public MySqlCommand COMMAND {
            get {
                MySqlCommand result = new MySqlCommand(QUERY, Function.conn);
                return result;
            }
        }
    }
}
