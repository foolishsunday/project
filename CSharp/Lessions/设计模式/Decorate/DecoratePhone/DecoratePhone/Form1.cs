using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DecoratePhone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phone phone = new ApplePhone();
            Decorator sticker = new Sticker(phone);
            label1.Text = sticker.Print();

            Decorator accessories = new Accessories(phone);
            label1.Text += accessories.Print();

            Sticker st = new Sticker(phone);
            Accessories acc = new Accessories(st);
            label2.Text += phone.Print();
        }
    }
}
