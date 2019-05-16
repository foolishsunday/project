using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObserverEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Publisher pub;
        Subscriber sub1;
        Subscriber sub2;

        private void Form1_Load(object sender, EventArgs e)
        {
            pub = new Publisher();
            sub1 = new Subscriber("sub1", pub);
            sub2 = new Subscriber("sub2", pub);

            sub1.Live = 100;
            sub2.Live = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pub.DoEvent();
            label1.Text = "sub1 Live:" + sub1.Live.ToString();
            label2.Text = "sub2 Live:" + sub2.Live.ToString(); 
        }
    }
}
