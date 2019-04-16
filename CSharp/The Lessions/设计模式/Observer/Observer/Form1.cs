using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subscriber sub = new Subscriber("LearningHard");
            TengXunGame txGame = new TengXunGame();

            txGame.Subscriber = sub;
            txGame.Symbol = "Tengxun Game";
            txGame.Info = "You have a news";

            label1.Text= txGame.Update();


        }
    }
}
