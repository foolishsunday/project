using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverEvent
{
    public class CustomEvent:EventArgs
    {// 自定义一个事件类来保存事件信息  
        public CustomEvent(string s)
        {
            message = s;
        }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
