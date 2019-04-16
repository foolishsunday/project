using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverEnemy
{
    public class BoomEvent : IObserver  //观察员1
    {
        public void Update()
        {
            BaseData.DisplayString = "爆炸";
        }
    }
}
