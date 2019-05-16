using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceAbstract
{
    //接口的使用：直接继承实现接口
    interface IWorker
    {
        string Work(string name, string job);
    }

    public class Work1 : IWorker
    {
        public string Work(string name, string job)
        {
            return string.Format("My name is {0},job is {1}",name,job);
        }
    }
    public class Work2 : IWorker
    {
        public string Work(string name, string job)
        {
            return string.Format("My name is {0},I dont't like {1}", name, job);
        }
    }
}
