using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class Television
    {
        private bool isopen = false;
        public bool isOpen
        {
            get { return isopen; }
            set { isopen = value; }
        }

        public string Switch()
        {
            if (isopen)
            {
                isopen = false;
                return "关闭电视机";
            }
            else
            {
                isopen = true;
                return "打开电视机";
            }
        }

    }
 

}
