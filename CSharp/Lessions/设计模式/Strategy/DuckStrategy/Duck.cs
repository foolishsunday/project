using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckStrategy
{
    public class Duck
    {
        IFlyBehavior flyBehavior;

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public string Swim()
        {
            return "swim";
        }
    }
}
