using ChristmasTree.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree.Builder
{
    class PresentsBuilder : DecorationsBuilder
    {
        public PresentsBuilder()
        {
            decoration = new Decoration("Presents");
        }
        public override string BuildColor()
        {
            Console.Write("Enter wrapping color: ");
            decoration["color"] = Console.ReadLine();
            return decoration["color"];
        }
        public override string BuildLenght()
        {
            throw new NotImplementedException();
        }
        public override string BuildSize()
        {
            Console.Write("Enter present size: ");
            decoration["size"] = Console.ReadLine();
            return decoration["size"];
        }
        public override string BuildNumberOfPresents()
        {
            throw new NotImplementedException();
        }
        public override string BuildType()
        {
            throw new NotImplementedException();
        }
        public override void Display()
        {
            Console.WriteLine();
            Console.WriteLine("Pressent color: " + decoration["color"]);
            Console.WriteLine("Pressent size: " + decoration["size"]);
        }
    }
}