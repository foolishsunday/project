using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverEvent
{
    public class Subscriber
    {
        private string ID;
        private string msg;
        private int live;

        public int Live
        {
            get { return live; }
            set { live = value; }
        }


        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }

        public Subscriber(string id, Publisher pub)
        {
            ID = id;
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        void HandleCustomEvent(object sender, CustomEvent e)
        {
            if (ID == "sub1")
                live -= 1;
            if(ID=="sub2")
                live += 1;
        }
    }
}
