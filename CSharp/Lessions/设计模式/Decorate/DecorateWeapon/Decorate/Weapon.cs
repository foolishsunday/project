using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorate
{
    public abstract class Weapon
    {
        public abstract string Attack();
    }

    public class LaserWeapon : Weapon
    {
        public override string Attack()
        {
            return "激光武器";
        }
    }
    public class MissileWeapon : Weapon
    {
        public override string Attack()
        {
            return "导弹武器";
        }
    }
}
