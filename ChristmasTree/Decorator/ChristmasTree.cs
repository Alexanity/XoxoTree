using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    internal class ChristmasTree : Item
    {
        private List<string> toys;
        private List<string> gerlands;
        private List<string> lights;
        private List<string> presents;
        public ChristmasTree(List<string> toys, List<string> garlands, List<string> lights, List<string> presents, int numPresents)
        {
            this.toys = toys;
            this.gerlands = garlands;
            this.lights = lights;
            this.presents = presents;
            this.NumPresents = numPresents;
        }
        public override void Display()
        {
            Console.WriteLine("The Christmas Tree has: ");
            ShowToys();
            ShowGarland();
            ShowLights();
            ShowPresents();
            Console.WriteLine("And the presents are this many: {0}", NumPresents);
        }
        private void ShowToys()
        {
            Console.WriteLine("The Toys are : " + string.Join(" ", toys));
        }
        private void ShowGarland()
        {
            Console.WriteLine("The Gerlands are : " + string.Join(" ", gerlands));
        }
        private void ShowLights()
        {
            Console.WriteLine("The Lights are : " + string.Join(" ", lights));
        }
        private void ShowPresents()
        {
            Console.WriteLine("The Presents are : " + string.Join(" ", presents));
        }
    }
}