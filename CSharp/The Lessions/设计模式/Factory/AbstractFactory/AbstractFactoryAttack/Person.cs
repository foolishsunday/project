using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryAttack
{
    public abstract class Person
    {
        public abstract string Print();
    }
    public abstract class Weapon
    {
        public abstract string Print();
    }
}
