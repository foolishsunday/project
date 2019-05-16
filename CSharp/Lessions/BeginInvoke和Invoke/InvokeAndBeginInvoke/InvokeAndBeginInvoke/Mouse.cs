using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvokeAndBeginInvoke
{
    public class Mouse
    {
        //public event DeleAction MouseEvent;

        public string MResult;
        public Mouse(Cat cat)
        {

            cat.CatEvent += new DeleAction(MouseEvent);
        }
        public void MouseEvent(string s)
        {
            MResult = "Mouse is running";
        }
    }
}
