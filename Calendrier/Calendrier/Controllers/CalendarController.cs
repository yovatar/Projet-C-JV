using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendrier
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
            }
            else
            {
                _gameOnList.Add(game);
            }
        }

        public void addEvent(Event myEvent)
        {
            if (_eventOnList.Contains(myEvent))
            {
                throw new EventAlreadyUsedException();
            }
            else
            {
                _eventOnList.Add(myEvent);
            }
        }

        public List<Event> GetEvents()
        {
            var pathBroadcast = @"..\..\Datas\Broadcast.json";
            string jsonFileBroadcast = File.ReadAllText(pathBroadcast);
            var pathEvent = @"..\..\Datas\Events.json";
            string jsonFileEvent = File.ReadAllText(pathEvent);

            dynamic fileBroadcast = JsonConvert.DeserializeObject(jsonFileBroadcast);
            dynamic fileEvent = JsonConvert.DeserializeObject(jsonFileEvent);
            List<Event> events = new List<Event>();

            foreach (dynamic singleEvent in fileEvent.data)
            {
                var broadcastName = "default";
                foreach (dynamic singleBroadcastName in fileBroadcast.data)
                {
                    broadcastName = singleBroadcastName.name.Value;
                }

                Event newEvent = new Event(singleEvent.name.Value, Convert.ToDateTime(singleEvent.releasdate.Value), broadcastName);
                events.Add(newEvent);
            }

            return events;
        }
    }
}
