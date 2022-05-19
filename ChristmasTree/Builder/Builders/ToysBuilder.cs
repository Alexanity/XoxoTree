using ChristmasTree.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree.Builder
{
    class ToysBuilder : DecorationsBuilder
    {
        public ToysBuilder()
        {
            decoration = new Decoration("Toys");
        }
        public override string BuildColor()
        {
            Console.Write("Enter toy color: ");
            decoration["color"] = Console.ReadLine();
            return decoration["color"];
        }
        public override string BuildLenght()
        {
            throw new NotImplementedException();
        }
        public override string BuildSize()
        {
            Console.Write("Enter toy size: ");
            decoration["size"] = Console.ReadLine();
            return decoration["size"];
        }
        public override string BuildNumberOfPresents()
        {
            throw new NotImplementedException();
        }
        public override string BuildType()
        {
            Console.Write("Enter toy type: ");
            decoration["type"] = Console.ReadLine();
            return decoration["type"];
        }
        public override void Display()
        {
            Console.WriteLine();
            Console.WriteLine("Toy color: " + decoration["color"]);
            Console.WriteLine("Toy size: " + decoration["size"]);
            Console.WriteLine("Toy type: " + decoration["type"]);
        }
    }
}