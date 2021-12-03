using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendrier
{
    public class Editor
    {
        private string _editorname;

        public Editor(string editorname)
        {
            _editorname = editorname;
        }
        public string EditorName
        {
            get { return _editorname; }
        }
    }
}
