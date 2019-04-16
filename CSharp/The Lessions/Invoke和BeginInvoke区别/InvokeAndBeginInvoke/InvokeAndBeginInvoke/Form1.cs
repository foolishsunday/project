using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InvokeAndBeginInvoke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         1、Invoke会阻止当前主线程的运行；BeginInvoke不会阻止当前主线程的运行，而是等当前主线程做完事情之后再执行
          BeginInvoke中的代码内容。
         2、这2个方法都是由主线程运行的，并不是异步执行，如果代码耗时过长，同样会造成界面卡死
         */
        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Text = "A";
            this.Invoke(new EventHandler(
                delegate {
                    this.button1.Text += "B";
                }));
            this.button1.Text += "C";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Text = "A";
            this.BeginInvoke(new EventHandler(
                delegate
                {
                    this.button2.Text += "B";
                }));
            this.button2.Text += "C";
        }
    }
}
