using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract YaBo CreateYaBo();
        public abstract YaJiao CreateYaJiao();
    }
    public class JiangXiFactory : AbstractFactory
    {
        public override YaBo CreateYaBo()
        {
            return new JiangXiYaBo();
        }
        public override YaJiao CreateYaJiao()
        {
            return new JiangXiYaJiao();
        }
    }
    public class ShangHaiFactory : AbstractFactory
    {
        public override YaBo CreateYaBo()
        {
            return new ShangHaiYaBo();
        }
        public override YaJiao CreateYaJiao()
        {
            return new ShangHaiYaJiao();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public abstract class YaBo
    {
        public abstract string Print();
    }
    public abstract class YaJiao
    {
        public abstract string Print();
    }

    /// <summary>
    /// 
    /// </summary>
    public class JiangXiYaBo : YaBo
    {
        public override string Print()
        {
            return "JiangXi ya bo!";
        }
    }
    public class ShangHaiYaBo : YaBo
    {
        public override string Print()
        {
            return "ShangHai ya bo!";
        }
    }
    public class JiangXiYaJiao : YaJiao
    {
        public override string Print()
        {
            return "JiangXi ya jiao!";
        }
    }
    public class ShangHaiYaJiao : YaJiao
    {
        public override string Print()
        {
            return "ShangHai ya jiao!";
        }
    }
}
