using System;
using System.Collections.Generic;

namespace ChristmasTree.Builder
{
    class DecorationsShop
    {
        //Director  
        public string ConstructToy(DecorationsBuilder decorationsBuilder)
        {
            string color = decorationsBuilder.BuildColor();
            string size = decorationsBuilder.BuildSize();
            string type = decorationsBuilder.BuildType();
            string result = "Colored " + color + ", " + type + " in type and " + size + " in size.";
            ChangeEvent(result);
            return result;
        }
        public string ConstructGerland(DecorationsBuilder decorationBuilder)
        {
            string color = decorationBuilder.BuildColor();
            string lenght = decorationBuilder.BuildLenght();
            string type = decorationBuilder.BuildType();
            string result = color + " in color, " + lenght + " in lenght" + " and " + type+".";
            ChangeEvent(result);
            return result;
        }
        public string ConstructChristmasLights(DecorationsBuilder decorationsBuilder)
        {
            string color = decorationsBuilder.BuildColor();
            string lenght = decorationsBuilder.BuildLenght();
            string result = color + " colored " + "and " + lenght + " in lenght.";
            ChangeEvent(result);
            return result;
        }
        public string ConstructPresents(DecorationsBuilder decorationsBuilder)
        {
            string color = decorationsBuilder.BuildColor();
            string size = decorationsBuilder.BuildSize();
            string result = color + " colored " + "and " + size + " in size.";
            ChangeEvent(result);
            return result;
        }
        // Observer
        private static void ChangeEvent(string addedItem)
        {
            Console.WriteLine($"\nThe tree has been changed! The new item is: {addedItem}");
        }
    }
}