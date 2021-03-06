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
        private Device[] _devices;
        private Editor[] _editors;
        private Broadcast[] _broadcast;


        private List<Game> _gameOnList = new List<Game>();
        private List<Event> _eventOnList = new List<Event>();

        public CalendarController()
        {
            _devices = GetDevices();
            _editors = GetEditors();
            _broadcast = GetBroadcast();
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

        public void AddEvent(Event myEvent)
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


        public Device[] GetDevices()
        {
            var pathDevice = @"..\..\Datas\Devices.json";
            string jsonFileDevice = File.ReadAllText(pathDevice);

            dynamic fileDevice = JsonConvert.DeserializeObject(jsonFileDevice);
            Device[] devices = new Device[10];

            foreach (dynamic singleDevice in fileDevice)
            {
                Device newDevice = new Device(singleDevice.name.Value);
                devices[singleDevice.id.Value] = newDevice;
            }

            return devices;
        }
        public Editor[] GetEditors()
        {
            var pathEditor = @"..\..\Datas\Editors.json";
            string jsonFileEditor = File.ReadAllText(pathEditor);

            dynamic fileEditor = JsonConvert.DeserializeObject(jsonFileEditor);
            Editor[] editors = new Editor[100];

            foreach (dynamic singleEditor in fileEditor)
            {
                Editor newEditor = new Editor(singleEditor.name.Value);
                editors[singleEditor.id.Value] = newEditor;
            }

            return editors;
        }
           public Broadcast[] GetBroadcast()
           {
               var pathBroadcast = @"..\..\Datas\Broadcast.json";
               string jsonFileBroadcast = File.ReadAllText(pathBroadcast);
        
               dynamic fileBroadcast = JsonConvert.DeserializeObject(jsonFileBroadcast);
               Broadcast[] broadcast = new Broadcast[100];
        
               foreach (dynamic singleBroadcast in fileBroadcast)
               {
                   Broadcast newBroadcast = new Broadcast(singleBroadcast.name.Value);
                   broadcast[singleBroadcast.id.Value] = newBroadcast;
               }
        
               return broadcast;
          }
        
          public List<Event> GetEvent()
          {
              var pathEvent = @"..\..\Datas\Event.json";
              string jsonFileEvent = File.ReadAllText(pathEvent);
        
              dynamic fileEvent = JsonConvert.DeserializeObject(jsonFileEvent);
              List<Event> events = new List<Event>();
        
              foreach (dynamic singleEvent in fileEvent)
              {
                  Event newEvent = new Event(singleEvent.name.Value, Convert.ToDateTime(singleEvent.releaseDate.Value));
        
                  foreach (dynamic broadcastId in singleEvent.broadcast)
                  {
                      newEvent.AddBroadcast(_broadcast[broadcastId]);
                  }
        
        
                  events.Add(newEvent);
              }
              return events;
          }

        public List<Game> GetGames()
        {
            var pathGame = @"..\..\Datas\Games.json";
            string jsonFileGame = File.ReadAllText(pathGame);

            dynamic fileGame = JsonConvert.DeserializeObject(jsonFileGame);
            List<Game> games = new List<Game>();

            foreach (dynamic singleGame in fileGame)
            {
                Game newGame = new Game(singleGame.name.Value, Convert.ToDateTime(singleGame.releaseDate.Value));

                foreach (dynamic deviceId in singleGame.devices)
                {
                    newGame.AddDevice(_devices[deviceId]);
                }
                
                foreach (dynamic editorId in singleGame.editors)
                {
                    newGame.AddEditor(_editors[editorId]);
                }
                
                games.Add(newGame);
            }
            return games;
        }
    }
}
