using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Xml;
using System.IO.Ports;
using System.Threading;

namespace learn_com
{

    public  partial class frmMain
    {
        public System.Windows.Forms.Timer textNewLineTimer = new System.Windows.Forms.Timer();

        public bool _isNewLine;

        private void textNewLineTimer_Tick(object obj, EventArgs e)
        {
            _isNewLine = true;
        }
        
        
        public void InitialTimer()
        {
            textNewLineTimer.Tick += new EventHandler(textNewLineTimer_Tick);
            textNewLineTimer.Interval = 100;

        }
        public void TimerStart()
        {
            textNewLineTimer.Start();
        }
        public void timer_stop()
        {
            textNewLineTimer.Stop();
        }

    }
}
