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
        private List<Broadcast> _broadcasts;

        public Event(string name, DateTime releasEventDate)
        {
            _name = name;
            _releasEventDate = releasEventDate;
            _broadcasts = new List<Broadcast>();
        }

        public string name
        {
            get { return _name; }
        }

        public DateTime releaseDate
        {
            get { return _releasEventDate; }
        }

        public void AddBroadcast(Broadcast broadcast)
        {
            _broadcasts.Add(broadcast);
        }
        public List<Broadcast> Broadcast
        {
            get { return _broadcasts; }
        }
    }
}
