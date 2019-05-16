using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

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

        SynchronizationContext m_SyncContext = null;
        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Text = "A";
            this.Invoke(new EventHandler(
                delegate {
                    this.button1.Text += "B";
                }));
            this.button1.Text += "C";
        }   //Invoke - 输出ABC

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Text = "A";
            this.BeginInvoke(new EventHandler(
                delegate
                {
                    this.button2.Text += "B";
                }));
            this.button2.Text += "C";
        }   //BeginInvoke - 输出ACB

        private bool flag = false;
        System.Timers.Timer tmr;
        private void button3_Click(object sender, EventArgs e)
        {

            Cat cat = new Cat();
            Mouse m = new Mouse(cat);
            cat.CatDo(Cat.ActionType.CRY);
            label1.Text = m.MResult;
         
        }

        private void timer_tick_loop()
        {
            flag = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Thread th = new Thread(new ThreadStart(DoWork));
            th.IsBackground = true;
            th.Start();

            if (tmr == null)
            {
                tmr = new System.Timers.Timer();
            }
            tmr.Interval = 10;
            tmr.Elapsed += (x, y) => { flag = true; };
            tmr.Enabled = true;
        }

        public delegate void Dele(object str);
        private void DoWork()
        {
            Dele myDele = UpdateUi;
            int i = 0;
            while (true)
            {
                if (flag.Equals(true))
                {
                    flag = false;
                    i++;
                    //this.BeginInvoke(myDele, new object[] { i.ToString() });
                    this.Invoke(new Action(() =>
                        {
                            lbltimer.Text = i.ToString();
                        }
                        ));
                    
                }
            }
        }

        
        private void UpdateUi(object s)
        {
            lbltimer.Text = (string)s;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(tmr!=null)
                tmr.Stop();     //此处为了关闭程序时，避免产生无法访问对象的内存释放问题
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);//此处为了关闭程序时，避免产生无法访问对象的内存释放问题
        }

        private void btnInvoke_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(CrossThreadFlush);
            th.IsBackground = true;
            th.Start();
        }
        private delegate void FlushClient();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CrossThreadFlush()
        {
            while (true)
            {
                Thread.Sleep(1000);
                ThreadFunction();
            }
        }

        int i = 0;
        private void ThreadFunction()
        {
            if (label2.InvokeRequired)  //等待异步
            {
                FlushClient fc = new FlushClient(ThreadFunction);
                this.Invoke(fc);
                
            }
            else
            {

                label2.Text = i.ToString();
            }
            i++;
        }

    }
}
