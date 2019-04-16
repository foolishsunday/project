using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public static class ControlContent    //控制中心代码
    {
        private static ICommand Command;
        public static void SetControlCommand(ICommand obj)
        {
            Command = obj;
        }
        public static string ExecuteControl()
        {
            return Command.Execute();
        }
    }
}
