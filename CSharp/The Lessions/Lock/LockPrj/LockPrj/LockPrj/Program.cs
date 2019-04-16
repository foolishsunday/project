using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LockPrj
{
    class Program
    {

        static void Main(string[] args)
        {
            Program pro = new Program();
            Thread thA = new Thread(pro.TaskDo);
            thA.Name = "线程1111";
            Thread thB = new Thread(pro.TaskDo);
            thB.Name = "线程22222";
            thA.Start();
            thB.Start();
            Console.ReadKey(); 
        }

        /*  lock(this) 锁定 当前实例对象，如果有多个类实例的话，lock锁定的只是当前类实例，对其它类实例无影响。所有不推荐使用。 
            lock(typeof(Model))锁定的是model类的所有实例。 这里的Model是指某个类名。
            lock(obj)锁定的对象是全局的私有化静态变量。外部无法对该变量进行访问。 
        */

        private static object obj = new object();
        public void TaskDo(object param)
        {
            lock (obj) //限定
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + ":" + i.ToString() + "\n");
                    Thread.Sleep(300);
                }
            }

        }
    }
}
