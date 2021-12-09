using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendrier.Controllers
{
    public class CalendarController
    {
        private List<Game> _gameOnList = new List<Game>();
        private List<Event> _eventOnList = new List<Event>();

        public CalendarController()
        {

        }

        public void AddGame(Game game)
        {
            if (_gameOnList.Contains(game))
            {
                throw new GameAlreadyUsedException();
            } else
            {
                _gameOnList.Add(game);
            }
        }

        public void addEvent(Event myEvent)
        {
            if (_eventOnList.Contains(myEvent))
            {
                throw new EventAlreadyUsedException();
            } else {
                _eventOnList.Add(myEvent);
            }
        }
    }
}
