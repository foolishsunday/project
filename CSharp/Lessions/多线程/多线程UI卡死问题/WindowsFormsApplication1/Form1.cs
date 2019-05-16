using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading; //需添加此引用

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void CalcHandle(int num);   //声明一个委托

        private void button1_Click(object sender, EventArgs e)
        {

            int content = 0;
            int.TryParse(textBox1.Text.ToString(), out content);  //表示将数字内容的字符串转为int类型,int.TryParse与 int.Parse类似，但它不会产生异常，转换成功返回 true，转换失败返回 false
            
            button1.Enabled = false;    //禁用按键，以免点击多次点击创建多个线程

            Thread th = new Thread(new ParameterizedThreadStart(TaskDo));   //用ParameterizedThreadStart创建一个带参数的线程
            th.Start(content);  //传递参数content给TaskDo        

        }
 
        //线程方法
        public void TaskDo(object num)
        {
            try
            {
                int r = 0;
                int.TryParse(num.ToString(), out r);

                Thread.Sleep(5000);     //模拟耗时的线程

                int result = r * r; //模拟取得计算结果：r的平方

                

                CalcHandle dele = new CalcHandle(UpdateUi); 
                this.Invoke(dele, result);

            }
            catch (Exception ex)
            {
                throw(ex);
            }
        }

        public void UpdateUi(int num)
        {

            label1.Text = num.ToString();
            if (button1.Enabled == false)   
                button1.Enabled = true;
        }


    }
}
