using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Invoke_PrintTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(PrintTime));
            th.IsBackground = true; //避免关闭关闭窗口时出现目标线程不存在的问题
            th.Start();
        }
        private void UpdateUi(Control ctrl, string s)
        {
            ctrl.Text = s;
        }

        private delegate void UpdateLabelDelegate(Control ctrl, string s);

        private void PrintTime()
        {
            if (label1.InvokeRequired.Equals(true))
            {
                UpdateLabelDelegate myDele = new UpdateLabelDelegate(UpdateUi);
                while (true)
                {
                    label1.Invoke(myDele, new object[] { label1, DateTime.Now.ToString() });

                }
            }
            else
            {
                while (true)
                {
                    label1.Text = DateTime.Now.ToString();
                }
            }
        }
    }
}
