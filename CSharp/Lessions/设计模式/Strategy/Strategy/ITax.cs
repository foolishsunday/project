using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    /*
    a)      提供公共接口或抽象类，定义需要使用的策略方法。（策略抽象类）
    b)      多个实现的策略抽象类的实现类。（策略实现类）
    c)      环境类，对多个实现类的封装，提供接口类型的成员量，可以在客户端中切换。
    d)      客户端 调用环境类 进行不同策略的切换。
    注：Jdk中的TreeSet和 TreeMap的排序功能就是使用了策略模式。
     * 
     * 优点：
    （1）策略模式提供了管理相关的算法族的办法。策略类的等级结构定义了一个算法或行为族。恰当使用继承可以把公共的代码移到父类里面，从而避免代码重复。
　　（2）使用策略模式可以避免使用多重条件(if-else)语句。多重条件语句不易维护，它把采取哪一种算法或采取哪一种行为的逻辑与算法或行为的逻辑混合在一起，统统列在一个多重条件语句里面，比使用继承的办法还要原始和落后。
     
     * 缺点：
    （1）客户端必须知道所有的策略类，并自行决定使用哪一个策略类。这就意味着客户端必须理解这些算法的区别，以便适时选择恰当的算法类。换言之，策略模式只适用于客户端知道算法或行为的情况。
　　（2）由于策略模式把每个具体的策略实现都单独封装成为类，如果备选的策略很多的话，那么对象的数目就会很可观。
     */

    //计算策略
    public interface ITax
    {
        double CalculateTax(double income);//接口与类有同样的函数
    }

    //个人所得税
    public class PersonalTax : ITax
    {
        public double CalculateTax(double income)//接口与类有同样的函数
        {
            return income * 0.12;
        }
    }

    //企业所得税
    public class EnterpriseTax : ITax
    {
        public double CalculateTax(double income)
        {
            return (income - 3500) > 0 ? (income - 3500) * 0.45 : 0.0;
        }
    }

    //使用例子
    //        TaxOperation op = new TaxOperation(new PersonalTax());
    //        Form1.ActiveForm.Text = "个人所得税为：" + op.GetTax(5000.00); 
    public class TaxOperation
    {
        private ITax m_tax;
        public TaxOperation(ITax tax)
        {
            this.m_tax = tax;
        }

        public double GetTax(double income)
        {
            return m_tax.CalculateTax(income);
        }
    }

    
}
