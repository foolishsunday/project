using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ThreadParam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private delegate void MyDelegate(string text);
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Task(object obj)
        {
            MyData d = (MyData) obj;

            string param = "x=" + d.x.ToString() + ",y=" + d.y.ToString();
            MyDelegate dele = new MyDelegate(UpdateUi);
            this.Invoke(dele, param);
        }
        private void UpdateUi(string param)
        {
            label1.Text = param;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ParameterizedThreadStart(Task));

            MyData data = new MyData(10, 55);

            th.Start(data);
        }

    }

    //带多个参数创建Thread，将其抽象为类
    public class MyData
    {
        public int x;
        public int y;

        public MyData(int a, int b)
        {
            x = a;
            y = b;
        }

    }
    
}
