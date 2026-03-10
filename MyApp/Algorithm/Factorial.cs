using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Algorithm
{
    internal class Factorial : ISolution
    {
        public void Solve()
        {
            int n = 8;
            int r = 1;
            for(int i=n; i>0; i--)
            {
                r *= i;
            }
            Console.WriteLine($"Factorial is : {r}");
        }
    }
}
