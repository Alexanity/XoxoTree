using ChristmasTree.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree.Builder
{
    class ChristmasLightsBuilder : DecorationsBuilder
    {
        public ChristmasLightsBuilder()
        {
            decoration = new Decoration("Christmas Lights");
        }
        public override string BuildColor()
        {
            Console.Write("Enter lights color: ");
            decoration["color"] = Console.ReadLine();
            return decoration["color"];
        }
        public override string BuildLenght()
        {
            Console.Write("Enter lights lenght: ");
            decoration["lenght"] = Console.ReadLine();
            return decoration["lenght"];
        }
        public override string BuildSize()
        {
            throw new NotImplementedException();
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
            Console.WriteLine("Light color: " + decoration["color"]);
            Console.WriteLine("Light lenght: " + decoration["lenght"]);
        }
    }
}