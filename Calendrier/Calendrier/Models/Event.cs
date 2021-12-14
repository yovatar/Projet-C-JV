using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendrier
{
    public class Event : Broadcast
    {
        private string _name;
        private DateTime _releasEventDate;

        public Event(string name, DateTime releasEventDate, string broadcastname) : base(broadcastname)
        {
            _name = name;
            _releasEventDate = releasEventDate;
        }

        public string name
        {
            get { return _name; }
        }

        public DateTime releaseDate
        {
            get { return _releasEventDate; }
        }
    }
}
