using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ISolution solution = new SecondLargestElement();
            solution.Solve();
        }
    }
}