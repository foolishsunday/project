using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObserverEnemy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BaseData.EnemyNumber = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IObserver boomEvent = new BoomEvent();
            IObserver enemy = new Enemy();
            Player player = new RealPlayer();
            player.AddObserver(boomEvent);//接口作为参数
            player.AddObserver(enemy);

            label1.Text = player.Display();//调用RealPlayer的Display
            player.Delete(boomEvent);

        }
    }
}
