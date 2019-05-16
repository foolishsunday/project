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
        /*策略模式（Strategy Pattern）
        策略模式提供了替代派生的子类，并定义类的每个行为，剔除了代码中条件的判断语句，使得扩展和结合新的行为变得更容易，
         * 根本不需要变动应用程序。策略模式可以避免使用多重条件转移语句，系统变得更新灵活。应用策略模式会产生很多子类，
         * 这符合高内聚的责任分配模式。*/
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
