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
    public enum QuestionType
    {
        Text = 0,
        MultipleChoice = 1
    }
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

            IWorker james = new Work1();
            IWorker kobe = new Work2();         

            label2.Text = james.Work("James", "coding");
            label3.Text = kobe.Work("Kobe", "swim");
        }

    }

    /*
    * 第1题：请定义一个接口IQuestion，有【标题】和【问题种类】两个属性，其中【问题种类】是只读的枚举类型QuestionType，
    * 另外还有一个方法获取该问题的答案（无参，返回字符串）。
    */
    public interface IQuestion
    {
        string Title { get; set; } //注意无分号，与java不同，c#的接口不能用public来修饰
        QuestionType QType { get; }  //此处因为是只读，所以只设为get
        string GetAnswer();
    }


    /* 第2题：请定义一个抽象类QuestionBase，实现第一题中的IQuestion接口，
    * 其中【问题种类】属性不在该抽象类中实现，而留在该抽象类的子类中实现；获取答案的方法有默认实现，返回字符串“默认答案”。
    */

    public abstract class QuestionBase : IQuestion
    {
        public string Title { get; set; }
        public abstract QuestionType QType { get; }     //abstract必须在子类中override
        public virtual string GetAnswer()               //virtual 关键字能修饰方法、属性、索引器以及事件等,virtual关键字就是告诉子类，此方法可以被override，但非强制
        {
            return "默认答案";
        }
        public abstract string MyProperty { get; set; } //属性也可以是抽象的，但子类继承时必须重写
    }
    /*
     * 第3题：请定义一个TextQuestion类，继承自第2题中的QuestionBase；获取答案的方法返回字符串”文本答案”。
     * 再定义一个MultipleChoiceQuestion类，继承自第2题中的QuestionBase；获取答案的方法返回字符串”单选答案”。
     */
    public class TextQuestion : QuestionBase
    {
        public override QuestionType QType
        {
            get { return QuestionType.Text; }
        }
        public override string GetAnswer()
        {
            return "文本答案";
        }
        public override string MyProperty
        {
            get;
            set;
        }
        internal int cnt;
    }
}
/*
 *1.接口的特点

    接口的定义是指定一组函数成员而不实现成员的引用类型，其它类型和接口可以继承接口。定义还是很好理解的，但是没有反映特点，接口主要有以下特点：

    (1)通过接口可以实现多重继承，C# 接口的成员不能有 public、protected、internal、private 等修饰符。原因很简单，接口里面的方法都需要由外面接口实现去实现方法体，那么其修饰符必然是 public。C# 接口中的成员默认是 public 的，java 中是可以加 public 的。
    (2)接口成员不能有 new、static、abstract、override、virtual 修饰符。有一点要注意，当一个接口实现一个接口，这2个接口中有相同的方法时，可用 new 关键字隐藏父接口中的方法。
    (3)接口中只包含成员的签名，接口没有构造函数，所有不能直接使用 new 对接口进行实例化。接口中只能包含方法、属性、事件和索引的组合。接口一旦被实现，实现类必须实现接口中的所有成员，除非实现类本身是抽象类。
    (4)C# 是单继承，接口是解决 C# 里面类可以同时继承多个基类的问题。
 * 
 * 2.接口和抽象类的区别
a. 接口用于规范，抽象类用于共性。抽象类是类，所以只能被单继承，但是接口却可以一次实现多个。

b. 接口中只能声明方法，属性，事件，索引器。而抽象类中可以有方法的实现，也可以定义非静态的类变量。

c. 抽象类可以提供某些方法的部分实现，接口不可以。抽象类的实例是它的子类给出的。接口的实例是实现接口的类给出的。

d. 在抽象类中加入一个方法，那么它的子类就同时有了这个方法。而在接口中加入新的方法，那么实现它的类就要重新编写（这就是为什么说接口是一个类的规范了）。

e. 接口成员被定义为公共的，但抽象类的成员也可以是私有的、受保护的、内部的或受保护的内部成员（其中受保护的内部成员只能在应用程序的代码或派生类中访问）。

f. 此外接口不能包含字段、构造函数、析构函数、静态成员或常量。

e. 还有一点，我们在VS中实现接口时会发现有2个选项，一个是实现接口，一个是显示实现接口。
 * 实现接口就是我们平常理解的实现接口，而显示实现接口的话，实现的方法是属于接口的，而不是属于实现类的。
 */