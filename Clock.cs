using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    class Clock:Control
    {
        System.Windows.Forms.Label m_label;
        Thread m_thread;
        Form m_form;
        bool m_stop;
        public Clock(System.Windows.Forms.Label label,Form form)
        {
            m_label = label;
            m_form = form;
            m_thread = new Thread(h_clock);
            this.CreateHandle();
            m_thread.Start();
            m_stop = false;
        }
        public void h_stop()
        {
            //m_thread.Interrupt();
            m_stop = true;
        }

        private void h_clock()
        {
            while(!m_stop)
            {
                //Console.WriteLine(m_stop);
                if (m_label.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        m_label.Text = Function.time;
                    }));
                }
                else
                {
                    m_label.Text = Function.time;
                }
                Thread.Sleep(10);
            }
        }

    }
}
