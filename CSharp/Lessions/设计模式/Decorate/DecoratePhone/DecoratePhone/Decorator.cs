using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratePhone
{
    public abstract class Decorator:Phone
    {
        private Phone m_phone;
        public Decorator(Phone phone)
        {
            this.m_phone = phone;
        }
        public override string Print()
        {
            if (this.m_phone != null)
            {
                return m_phone.Print();
            }
            else
                return "NG";
        }
    }
}
