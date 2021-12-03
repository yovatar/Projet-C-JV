using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendrier
{
    public class Device
    {
        private string _devicename;

        public Device(string devicename) 
        {
            _devicename = devicename;
        }
        public string DeviceName
        {
            get { return _devicename; }
        }

    }
}
