using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// 类的适配器模式
    /// </summary>
    public interface IThreeHole //三角插头
    {
        string AdapterPrint();
    }
    public abstract class TwoHole    //用户期待的两脚插头
    {
        public string Print()
        {
            return "两角插头";
        }
    }
    public class AdapterManager:TwoHole,IThreeHole  // 适配器
    {
        public string AdapterPrint()
        {
            return this.Print();
        }
    }
}
