using ChristmasTree.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree.Builder
{
    class GerlandsBuilder : DecorationsBuilder
    {
        public GerlandsBuilder()
        {
            decoration = new Decoration("Gerland");
        }
        public override string BuildColor()
        {
            Console.Write("Enter gerland color: ");
            decoration["color"] = Console.ReadLine();
            return decoration["color"];
        }
        public override string BuildLenght()
        {
            Console.Write("Enter gerland lenght: ");
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
            Console.Write("Enter gerland type: ");
            decoration["type"] = Console.ReadLine();

            return decoration["type"];
        }

        public override void Display()
        {
            Console.WriteLine();
            Console.WriteLine("Gerland color: " + decoration["color"]);
            Console.WriteLine("Gerland lenght: " + decoration["lenght"]);
            Console.WriteLine("Gerland type: " + decoration["type"]);
        }
    }
}