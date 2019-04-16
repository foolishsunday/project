using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterfaceAbstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextQuestion tq = new TextQuestion();
            label1.Text =  tq.QType.ToString();
        }

    }

    /*
    * 第1题：请定义一个接口IQuestion，有【标题】和【问题种类】两个属性，其中【问题种类】是只读的枚举类型QuestionType，
    * 另外还有一个方法获取该问题的答案（无参，返回字符串）。
    */
    interface IQuestion
    {
        string Title { get; set; } //注意无分号，与java不同，c#的接口不能用public来修饰
        QuestionType QType { get; }  //此处因为是只读，所以只设为get
        string GetAnswer();
    }


/* 第2题：请定义一个抽象类QuestionBase，实现第一题中的IQuestion接口，
* 其中【问题种类】属性不在该抽象类中实现，而留在该抽象类的子类中实现；获取答案的方法有默认实现，返回字符串“默认答案”。
*/

    public enum QuestionType
    {
        Text = 0,
        MultipleChoice = 1
    }
    public abstract class QuestionBase : IQuestion
    {
        public abstract QuestionType QType { get; }     //【问题种类】属性不在该抽象类中实现，而留在该抽象类的子类中实现
        public virtual string GetAnswer()               //获取答案的方法有默认实现，返回字符串“默认答案”。
        {
            return "默认答案";
        }
        public string Title { get; set; }
    }
}
