using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TestTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayTimer.Start();
        }

        System.Timers.Timer displayTimer;
        private void Form1_Load(object sender, EventArgs e)
        {
            //设置时间间隔ms
            int interval = 5;
            displayTimer = new System.Timers.Timer(interval);
            //设置重复计时
            displayTimer.AutoReset = true;
            //设置执行System.Timers.Timer.Elapsed事件

            displayTimer.Elapsed += new System.Timers.ElapsedEventHandler(Displaytimer_tick);

            //datagridview
            dataGridView1.Columns.Add("name1", "title1");
            dataGridView1.Columns.Add("name2", "title2");
            dataGridView1.Columns.Add("name2", "title3");
            dataGridView1.Columns.Add("name2", "title4");
            dataGridView1.Columns.Add("name2", "title5");
            
            //实例化委托
            myDeleCall = new DeleCall(UpdateForm);
        }

        public delegate void DeleCallback();
        private void Displaytimer_tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            //防止在窗口句柄初始化之前就走到下面的代码
            while (!this.IsHandleCreated)
            {
                ;
            }
            try
            {
                this.Invoke(new DeleCallback(ShowData));
            }
            catch { }
        }
        int i = 0;
        private void ShowData()
        {
            i++;
            label1.Text = i.ToString();

            int index = dataGridView1.Rows.Add(1);
            dataGridView1.Rows[index].Cells[0].Value = "cell11:" + i.ToString() ;
            dataGridView1.Rows[index].Cells[1].Value = "cell12:" + i.ToString();
            dataGridView1.Rows[index].Cells[2].Value = "cell13:" + i.ToString();
            dataGridView1.Rows[index].Cells[3].Value = "cell14:" + i.ToString();
            dataGridView1.Rows[index].Cells[4].Value = "cell15:" + i.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.Name = "UIThread";
            Thread th = new Thread(new ThreadStart(StartThread));
            th.Start();

        }

        private delegate void DeleHandler();
        private void StartThread()
        {
            Thread.CurrentThread.Name = "Work Thread";
            label2.Invoke(new DeleHandler(UpdateUi));
        }
        private void UpdateUi()
        {
            label2.Text = (Thread.CurrentThread.Name);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(delegate {
                ThreadDo(100);
            }));
            t.Start();
        }

        public delegate void DeleCall(string msg);
        public DeleCall myDeleCall;
        public void ThreadDo(int n)
        {
            for (int i = 0; i < n; i++)
            {
                this.BeginInvoke(myDeleCall,i.ToString());
                Thread.Sleep(1000);
            }
        }
        public void UpdateForm(string msg)
        {
            button4.Text = msg;
        }
    }
}
