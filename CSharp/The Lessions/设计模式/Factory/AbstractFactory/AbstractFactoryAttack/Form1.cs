using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AbstractFactoryAttack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbstractFactory attackPerson = new AttackPersonFactory();
            AbstractFactory gunPerson = new GunPersonFactory();

            Person per = attackPerson.person();
            label1.Text = per.Print();

            Weapon weapon = attackPerson.weapoon();
            label2.Text = weapon.Print();
        }
    }
}
