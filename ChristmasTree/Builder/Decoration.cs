using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree.Builder.Builders
{
    class Decoration
    {
        private string decorationType;
        private Dictionary<string, string> _decorations =
        new Dictionary<string, string>();
        public Decoration(string decorationType)
        {
            this.decorationType = decorationType;
        }
        public string this[string key]
        {
            get { return _decorations[key]; }
            set { _decorations[key] = value; }
        }
    }
}