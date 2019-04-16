using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckStrategy
{
    public interface IFlyBehavior
    {
        string Fly(string type);
    }

    public class FlyWithWings:IFlyBehavior
    {
        public string Fly(string type)
        {
            return "In the Sky";
        }
    }
    public class FlyNoWay : IFlyBehavior
    {
        public string Fly(string type)
        {
            return "On Land";
        }
    }
}
