using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Command
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool btnStatus = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (btnStatus)
                btnStatus = false;
            else
                btnStatus = true;

            TeleisionCommand tv = new TeleisionCommand();
            tv.isOn = btnStatus;
            ControlContent.SetControlCommand(tv);
            label1.Text = ControlContent.ExecuteControl();
        }
        /*
         * 命令模式：
         将一个请求封装为一个对象，从而可用不同的请求对客户进行参数化；对请求排队或记录日志，以及支持可撤销的操作

        将“发出请求的对象”和”接收与执行这些请求的对象”分隔开来。

        实现方式：

        a)     抽象的命令角色 ， 如：菜单（规定可以点哪些菜）

        b)     具体的命令角色（实现a 维护一个对c的引用），如：订单（已点的菜）

        c)     接收者（具体执行命令的角色），实际操作时，很常见使用"聪明"命令对象，也就是直接实现了请求，而不是将工作委托给c (弊端？) 如：厨师接收订单后做菜

        d)     调用者（维护一个对a的引用），如：服务员负责点菜并把订单推给厨师

        e)     客户端 调用d发出命令进而执行c的方法，如：顾客点餐

 
        效果：
        1)、command模式将调用操作的对象和实现该操作的对象解耦
        2)、可以将多个命令装配成一个复合命令，复合命令是Composite模式的一个实例
        3)、增加新的command很容易，无需改变已有的类
        适用性：
        1)、抽象出待执行的动作以参数化某对象
        2)、在不同的时刻指定、排列和执行请求。如请求队列
        3)、支持取消操作
        4)、支持修改日志
        5)、用构建在原语操作上的高层操作构造一个系统。支持事物
         */
    }
}
