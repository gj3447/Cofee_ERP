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
    public partial class Kind_Create_From : Form
    {
        DBS.Kind m_kind;
        enum state { Add, Change };
        string m_message;

        private state m_state;
        public Kind_Create_From()
        {
            InitializeComponent();
        }
        public void h_add()
        {
            m_state = state.Add;
            button_Update.Text = "추가";
            m_message = "종류 가 생성되었습니다";
        }
        public void h_change(DBS.Kind kind)
        {
            m_kind = kind;
            m_state = state.Change;
            textBox_Name.Text = kind.name;
            button_Update.Text = "변환";
            m_message = "종류 이름이 변환 되었습니다";
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text != "")
            {
                switch (m_state)
                {
                    case state.Add:
                        {
                            m_kind = new DBS.Kind();
                            m_kind.name = textBox_Name.Text;
                            m_kind.status = "판매";
                            m_kind.save();
                            break;
                        }
                    case state.Change:
                        {
                            m_kind.chage_name(textBox_Name.Text);
                            break;
                        }
                }
                MessageBox.Show(m_message);
                this.Close();
            }
            else
            {
                MessageBox.Show("이름을 입력하세요");
            }
            
        }
    }
}
