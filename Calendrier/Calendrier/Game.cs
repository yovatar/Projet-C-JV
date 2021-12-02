using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder
{
    public class Game
    {
        private string _name;
        private DateTime _releasGameDate;
        private List<Editor> _editor;
        private List<Device> _devices;

        public Game(string name,DateTime releasGameDate)
        {
            _name = name;
            _releasGameDate = releasGameDate;
        }
        public void AddDevice(Device device) 
        {
            _devices.Add(device);
        }
        public void AddEditor(Editor editor)
        {
            _editor.Add(editor);
        }
    }

}
