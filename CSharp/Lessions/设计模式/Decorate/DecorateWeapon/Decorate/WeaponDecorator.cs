using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorate
{
    public class WeaponDecorator:IWeaponUpgrade
    {
        protected IWeaponUpgrade weaponUpgrade;
        public WeaponDecorator(IWeaponUpgrade weapon)
        {
            this.weaponUpgrade = weapon;
        }
        public virtual string Attack()
        {
            return this.weaponUpgrade.Attack();
        }
    }

    public class Knife : WeaponDecorator
    {
        public Knife(IWeaponUpgrade weapon)
            : base(weapon)
        { }
        public override string Attack()
        {
            return base.Attack();
        }
    }
    public class Hammer : WeaponDecorator //锤子
    {
        public Hammer(IWeaponUpgrade weapon) : base(weapon) { }
        public override string Attack()
        {
            return base.Attack();
        }
    }
}
