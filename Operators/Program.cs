using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 100 + 50;
            int sum2 = sum1 + 50;
            int sum3 = sum2 + sum1;
            int sum4 = 10 - 10;

            Console.WriteLine(sum2 + " + " + sum1 + " = " + sum3);
            Console.WriteLine("100" + " + " + " 50 " + sum1);
            Console.WriteLine(sum1 + " + " + " 50 " + " = " + sum2);
            Console.WriteLine(sum4);
        }
    }
}