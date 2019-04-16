using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryAttack
{
    /// <summary>
    /// 人物扩展
    /// </summary>
    public class AttackPerson:Person
    {
        public override string Print()
        {
            return "剑士";
        }
    }
    public class GunPerson : Person
    {
        public override string Print()
        {
            return "枪手";
        }
    }
}
