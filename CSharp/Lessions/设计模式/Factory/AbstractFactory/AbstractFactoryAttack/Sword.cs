using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryAttack
{
    /// <summary>
    /// 武器扩展
    /// </summary>
    public class Sword:Weapon
    {
        public override string Print()
        {
            return "剑";
        }
    }
    public class AK47 : Weapon
    {
        public override string Print()
        {
            return "AK47";
        }
    }
}
