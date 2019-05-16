using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbstractFactory jiangxiFactory = new JiangXiFactory();
            YaBo jiangxiYabo = jiangxiFactory.CreateYaBo();
            label1.Text = jiangxiYabo.Print();

            YaJiao jiangxiYajiao = jiangxiFactory.CreateYaJiao();
            label2.Text = jiangxiYajiao.Print();


        }
    }
}
