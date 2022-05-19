using ChristmasTree.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree.Builder
{
    abstract class DecorationsBuilder
    {
        protected Decoration decoration;
        public Decoration Decoration => decoration;
        public abstract string BuildColor();
        public abstract string BuildLenght();
        public abstract string BuildSize();
        public abstract string BuildType();
        public abstract string BuildNumberOfPresents();
        public abstract void Display();
    }
}