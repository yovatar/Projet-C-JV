using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendrier
{
    public class Game
    {
        private string _name;
        private DateTime _releasGameDate;
        private List<Editor> _editors;
        private List<Device> _devices;

        public Game(string name,DateTime releasGameDate)
        {
            _name = name;
            _releasGameDate = releasGameDate;
            _devices = new List<Device>();
            _editors = new List<Editor>();
        }
        public void AddDevice(Device device) 
        {
            _devices.Add(device);
        }
        public void AddEditor(Editor editor)
        {
            _editors.Add(editor);
        }

        public string Name
        {
            get { return _name; }
        }
        public DateTime ReleasGame
        {
            get { return _releasGameDate; }
        }
        public List<Editor> Editor
        {
        get { return _editors; }
        }

        public List<Device> Device
        {
            get { return _devices; }
        }

        public static List<Game> getAll()
        {
            List<Game> games = new List<Game>();
            return games;
        }
    }

}
