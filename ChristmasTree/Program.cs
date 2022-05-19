using ChristmasTree.Builder;
using ChristmasTree.GlobalConstants;
using System;
using System.Collections.Generic;

namespace ChristmasTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int randNumPresent = rd.Next(0, 10);

            //------------***BUILDER***-------------
            DecorationsBuilder builder;
            DecorationsShop shop = new DecorationsShop();
            
            //toys
            builder = new ToysBuilder();
            string toysOuput = shop.ConstructToy(builder);
            builder.Display();
            Console.WriteLine(Constants.line);

            List<string> totalToyOutup = new List<string>();
            totalToyOutup.Add(toysOuput);

            //gerlands
            builder = new GerlandsBuilder();
            string firstGerlandOuput = shop.ConstructGerland(builder);
            string secondGerlandOuput = shop.ConstructGerland(builder);

            List<string> totalGerlandOutup = new List<string>();
            totalGerlandOutup.Add(firstGerlandOuput);
            totalGerlandOutup.Add(Constants.column);
            totalGerlandOutup.Add(secondGerlandOuput);
            builder.Display();
            builder.Display();
            
            Console.WriteLine(Constants.line);
            //lights
            builder = new ChristmasLightsBuilder();
            string lightsOuput = shop.ConstructChristmasLights(builder);
            builder.Display();

            List<string> totalLightOutup = new List<string>();
            totalLightOutup.Add(lightsOuput);

            Console.WriteLine(Constants.line);
            //presents
            builder = new PresentsBuilder();
            string presentOuput =  shop.ConstructPresents(builder);
            builder.Display();

            List<string> totalPresentsOutup = new List<string>();
            totalPresentsOutup.Add(presentOuput);

            Console.WriteLine(Constants.line);

            //------------***BUILDER***-----------------
            Console.WriteLine();

            //--------------***DECORATOR***-------------
            ChristmasTree Tree = new ChristmasTree(totalToyOutup, totalGerlandOutup, totalLightOutup, totalPresentsOutup, randNumPresent);
            Tree.Display();
            //--------------***DECORATOR***-------------

            Console.WriteLine();
            Tree t = new Tree();
            t.CreateTree();
            Console.ReadLine();
        }
    }
}