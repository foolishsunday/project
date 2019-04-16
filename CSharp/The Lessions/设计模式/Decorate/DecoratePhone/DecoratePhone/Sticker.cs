using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratePhone
{
    public class Sticker:Decorator
    {
        public Sticker(Phone phone) : base(phone) { }
        public override string Print()
        {

            return base.Print()+" 现在苹果手机有贴膜了！";

        }
    }
    public class Accessories : Decorator
    {
        public Accessories(Phone phone) : base(phone) { }
        public override string Print()
        {
            return base.Print() + " 现在苹果手机有挂件了！";
        }
    }
}
