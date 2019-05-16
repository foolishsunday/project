using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvokeAndBeginInvoke
{
    public delegate void DeleAction(string s); 
    public class Cat
    {
        public Cat()
        {
            
        }
        public enum ActionType
        {
            CRY,
            LAUGH
        }

        public event DeleAction CatEvent;
        public void CatDo(ActionType act)
        {
            if (act == ActionType.CRY)
            {
                CatEvent("Cat is crying!");
            }
        }
    }
}
