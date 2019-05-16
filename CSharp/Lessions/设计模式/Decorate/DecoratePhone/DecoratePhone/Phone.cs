using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratePhone
{
    public abstract class Phone
    {
        public abstract string Print();
    }
    public class ApplePhone : Phone
    {
        public override string Print()
        {
            return "I have an apple phone!";
        }
    }
}
