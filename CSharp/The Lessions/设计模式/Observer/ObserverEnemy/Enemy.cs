using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverEnemy
{
    public class Enemy : IObserver
    {
        public void Update()
        {
            BaseData.EnemyNumber -= 1;  //敌人少1个
        }
    }
}
