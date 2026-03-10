using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Algorithm
{
    internal class ArmstrongNumber : ISolution
    {
        public void Solve()
        {
            int originalNum = 103;
            int num = originalNum;
            
            int divisor = 1;
            int digit = 1;

            int temp = num;
            while (temp >= 10)
            {
                temp /= 10;
                digit++;
                divisor *= 10;
            }

            temp = 0;
            while (num > 0)
            {
                temp += (int)Math.Pow(num/divisor, digit);
                num %= divisor;
                divisor /= 10;
            }

            Console.WriteLine($"input : {originalNum}, output : {temp}");
        }
    }
}
