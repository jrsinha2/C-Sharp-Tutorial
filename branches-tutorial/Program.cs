using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =0;i<2;i++)
            {   int j =0;
                while(j<4)
                {
                    Console.WriteLine($"{j}");
                    j++;
                }
            }
        }
    }
}
