using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendrier
{
    public class Broadcast : Event
    {
        private string _broadcastname;

        public Broadcast(string broadcastname, string name, DateTime releasEventDate) : base(name, releasEventDate)
        {
            _broadcastname = broadcastname;
        }
        public string BroadcastName
        {
            get { return _broadcastname; }
        }
    }
}
