using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverEvent
{
    public class Publisher
    {
        // 使用 EventHandler<T> 声明一个事件 
        public event EventHandler<CustomEvent> RaiseCustomEvent;

        public void DoEvent()
        {
            OnRaiseCustomEvent(new CustomEvent("Working!!!!"));
        }

        //使用虚方法，让子类可以重写
        protected virtual void OnRaiseCustomEvent(CustomEvent e)
        {
            // 定义一个局部变量，已防止最后一个订阅者刚好在检查null后取消订阅  
            EventHandler<CustomEvent> handler = RaiseCustomEvent;

            if (handler != null)
            {
                e.Message += String.Format("at {0}",DateTime.Now.ToString());

                // 这是最重要的一句。  
                // 此时执行的  handler已经是一个多播委托（如果有多个订阅者或观察者注册）。  
                // 既然是多播委托，就可以依次调用各个 回调函数 （既然是回调函数，实际的执行就由订阅者类决定）。  
                //这里面传入一个this, 就代表 事件源（或发布者 或 被观察者 都一个意思）  
                handler(this, e);
            }
        }
    }
}
