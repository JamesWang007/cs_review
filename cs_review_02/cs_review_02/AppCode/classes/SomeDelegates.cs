using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_review_02
{
    class SomeDelegates
    {
        public delegate int MyDelegate1 (int x, int y);
        public delegate void MyClickHandler(object sender, MyEventAgrs e);
    }

    class MyEventAgrs: EventArgs
    {
        public string Cliker { get; set; }
    }

    class SomeEvents
    {
        public event SomeDelegates.MyClickHandler MyClick;
        public void Click()
        {            
            // delegate 4 - event
            //MyClick(this, new MyEventAgrs(){ Cliker = "James"});

        }
    }
}
