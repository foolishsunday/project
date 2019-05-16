using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TemplatePattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Play1 play1 = new Play1();
            play1.Run();

            listBox1.Items.Add(BaseData.DisplayString);

        }
    }

    public abstract class Play  //模板
    {
        protected abstract void start();      //protected 是受保护的,只有当前类的成员与继承该类的类才能访问
        protected abstract void move();
        protected abstract void stop();
        public void Run()
        {
            start();
            move();
            stop();
        }
    }

    public class Play1 : Play
    {
        protected override void start()
        {
            BaseData.DisplayString += "玩家1开始运行..." + System.Environment.NewLine;
        }
        protected override void move()
        {
            BaseData.DisplayString += "玩家1移动..." + System.Environment.NewLine;
        }
        protected override void stop()
        {
            BaseData.DisplayString += "玩家1停止..." + System.Environment.NewLine;
        }
    }

    public static class BaseData    //数据中转
    {
        public static string DisplayString { get; set; }
        public static int EnemyNumber { get; set; } 
    }
}
