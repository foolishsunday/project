using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyWeight
{
    //抽象享元类，提供享元类具体的方法
    public abstract class FlyWeight
    {
        
        public abstract string Operation(int extstate);
    }

    //具体的享元对象，这样我们不把每个字母设计成一个单独的类，而是作为把共享的字母作为享元对象的内部状态
    public class ConcreteFlyWietht : FlyWeight
    {
        //内部状态
        private string instate;

        //构造函数
        public ConcreteFlyWietht(string innerstate)
        {
            this.instate = innerstate;
        }

        // 享元类的实例方法
        public override string Operation(int extstate)
        {
            return "number is " + extstate.ToString();
        }
    }

    
}
