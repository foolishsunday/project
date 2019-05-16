using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryAttack
{
    public abstract class AbstractFactory
    {
        public abstract Person person();
        public abstract Weapon weapoon();
    }
    public class AttackPersonFactory : AbstractFactory
    {
        public override Person person()
        {
            return new AttackPerson();
        }
        public override Weapon weapoon()
        {
            return new Sword();
        }
    }
    public class GunPersonFactory : AbstractFactory
    {
        public override Person person()
        {
            return new GunPerson();
        }
        public override Weapon weapoon()
        {
            return new AK47();
        }
    }
}
