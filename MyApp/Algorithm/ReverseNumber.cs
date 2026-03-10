using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Algorithm
{
    internal class ReverseNumber : ISolution
    {
        public void Solve()
        {
            _ = int.TryParse(Console.ReadLine(), out int n);
            int reversedNumber = 0;
            while (n > 0)
            {
                reversedNumber = (reversedNumber * 10) + (n % 10);
                n /= 10;
            }
            Console.WriteLine($"Reversed number : {reversedNumber}");
        }
    }
}
