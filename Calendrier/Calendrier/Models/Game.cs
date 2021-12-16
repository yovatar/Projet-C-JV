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

        public static List<Game> getAll()
        {
            List<Game> games = new List<Game>();
            return games;
        }
    }

}
