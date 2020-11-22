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
    public partial class Log_Table_Form : Form
    {
        public Log_Table_Form()
        {
            InitializeComponent();
            h_start();
        }
        public void h_start()
        {
            string query = "SELECT * FROM Login";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, Function.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
