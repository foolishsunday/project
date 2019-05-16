using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestFunc
{
    public class Function
    {
        public static byte[] sliceBytes2Array(byte[] ab, int s, int t)
        {
            byte[] newA = ab.Skip(s).Take(t).ToArray();
            return newA;
        }   
    }
}
