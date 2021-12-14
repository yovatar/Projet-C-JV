using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendrier
{
    public class Broadcast
    {
        private string _broadcastname;

        public Broadcast(string broadcastname)
        {
            _broadcastname = broadcastname;
        }
        public string BroadcastName
        {
            get { return _broadcastname; }
        }
    }
}
