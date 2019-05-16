using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class TeleisionCommand:ICommand//电视机命令对象
    {
        //private bool ison;
        //public bool isOn
        //{
        //    get { return ison; }
        //    set { ison = value; }
        //}
        public bool isOn;
        private Television Tv = new Television();
        public string Execute()
        {
            Tv.isOpen = isOn;
            return Tv.Switch();
        }
    }
}
