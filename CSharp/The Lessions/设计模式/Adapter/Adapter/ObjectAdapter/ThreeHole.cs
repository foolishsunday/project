using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectAdapter
{
    public abstract class ThreeHole
    {
        public virtual string AdapterPrint()
        {
            return "三脚插头";
        }
    }
    public class TwoHole
    {
        public string Print()
        {
            return "两脚插头";
        }
    }

    public class AdapterManager : ThreeHole
    {
        TwoHole twoH = new TwoHole();
        public override string AdapterPrint()
        {
            return twoH.Print();
        }
    }
}
