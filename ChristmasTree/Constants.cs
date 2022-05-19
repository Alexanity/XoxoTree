using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree.GlobalConstants
{
    public class Constants
    {
        public const string line = "/--------------------------------";
        public const string column = "|";
    }
    public class Tree
    {
        int n = 5;
        public void CreateTree()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    string branch = new String('*', j);
                    Console.WriteLine(branch.PadLeft(n + 3) + "*" + branch);
                }
            }
        }
    }
}
