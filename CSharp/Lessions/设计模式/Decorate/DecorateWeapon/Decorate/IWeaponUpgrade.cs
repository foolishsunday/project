using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorate
{
    public interface IWeaponUpgrade
    {
        string Attack();
    }

    public class ComUpgrade : IWeaponUpgrade
    {
        public string Attack()
        {
            return "IronMan start to atack: ";
        }
    }
}
