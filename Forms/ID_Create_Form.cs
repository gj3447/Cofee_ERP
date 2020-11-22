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
    public partial class ID_Create_Form : Form
    {
        public ID_Create_Form()
        {
            InitializeComponent();
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            DBS.ID id = new DBS.ID();
            id.id = textBox_ID.Text;
            id.password = Function.encryptAES128(textBox_Password.Text);
            if(id.overlap())
            {
                MessageBox.Show("중복된 아이디가 있습니다");
            }
            else
            {
                id.save();
            }
            Close();
        }
    }
}
