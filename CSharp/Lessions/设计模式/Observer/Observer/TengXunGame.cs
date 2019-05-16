using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class TengXunGame
    {
        //订阅者对象
        public Subscriber Subscriber { get; set; }  //类里面建类
        public string Symbol { get; set; }
        public string Info { get; set; }
        public string Update()
        {
            if (Subscriber != null)
            {
                return Subscriber.ReceiveAndPrint(this);    //调用类的方法
            }
            else
                return "null";
        }
    }
}
