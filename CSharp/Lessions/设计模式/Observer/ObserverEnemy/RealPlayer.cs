using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverEnemy
{
    public class RealPlayer:Player
    {
        public override string Display()
        {
            Notify();
            return BaseData.DisplayString + BaseData.EnemyNumber.ToString();
        }
    }
}
