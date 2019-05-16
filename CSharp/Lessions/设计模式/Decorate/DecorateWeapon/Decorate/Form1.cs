using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Decorate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComUpgrade comup = new ComUpgrade();
            Knife knife = new Knife(comup);
            Hammer hammer = new Hammer(knife);
            label1.Text = hammer.Attack();
        }
    }
}
