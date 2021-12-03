using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendrier
{
    public class Event
    {
        private string _name;
        private DateTime _releasEventDate;
        private List<Broadcast> _boradcast;

        public Event(string name, DateTime releasEventDate) 
        {
            _name = name;
            _releasEventDate = releasEventDate;
        }
        public void Addbroadcast(Broadcast broadcast) 
        {
            _boradcast.Add(broadcast);
        }
    }
}
