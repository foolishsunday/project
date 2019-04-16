using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    //订阅者类
    public class Subscriber
    {
        public string Name { get; set; }
        public Subscriber(string name)
        {
            this.Name = name;
        }
        public string ReceiveAndPrint(TengXunGame txGame)
        {
            return string.Format("name={0}, symbol={1}, info={2}", Name, txGame.Symbol, txGame.Info);
        }
    }
}
