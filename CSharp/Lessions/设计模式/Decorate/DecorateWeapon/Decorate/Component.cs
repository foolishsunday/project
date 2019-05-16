using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorate
{
    public abstract class Component
    {
        private string name = string.Empty;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract string SelfDescribed();

    }
    public class RightHandComponent : Component
    {
        public RightHandComponent() : this("右部件") { }
        public RightHandComponent(string name)
        {
            base.Name = name;
        }
        public override string SelfDescribed()
        {
            return ("自描述：我是->" + base.Name);
        }
    }
    public class LeftHandComonent : Component
    { 
        public LeftHandComonent():this("机甲1号左部件"){}
        public LeftHandComonent(string name)
        {
            base.Name=name;
        }
        public override string SelfDescribed()
        {
            return ("自描述：我是->" + base.Name);
        }
    }
}
