using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Strategy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaxOperation op = new TaxOperation(new PersonalTax());
            Form1.ActiveForm.Text = "个人所得税为：" + op.GetTax(5000.00); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaxOperation op = new TaxOperation(new EnterpriseTax());
            Form1.ActiveForm.Text = "企业所得税为：" + op.GetTax(60000.00); 
        }
    }
}
