using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ThreadCallback
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void MyCallback(string param);
        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread();
        }
    }

    public class MyClass
    { 
        public MyCallback 
    }
}
