using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    public abstract class Item
    {
        private int numPresents;
        public int NumPresents
        {
            get { return numPresents; }
            set { numPresents = value; }
        }
        public abstract void Display();
    }
}