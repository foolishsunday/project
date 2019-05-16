using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FlyWeight
{
    public class FlyWeightFactory
    {
        public Hashtable flyweight = new Hashtable();
        public FlyWeightFactory()
        {
            flyweight.Add("A",new ConcreteFlyWietht("A"));
            flyweight.Add("b", new ConcreteFlyWietht("A"));
            flyweight.Add("A", new ConcreteFlyWietht("A"));
        }
    }
}
