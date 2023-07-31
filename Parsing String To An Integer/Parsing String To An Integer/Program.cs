using System;

namespace Parsing_STRING_To_An_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85";
            string stringForInt = "12345";
            float num1 = float.Parse(stringForFloat);
            int num2 = int.Parse(stringForInt);
            float resultFloat = num1 + num2;

            Console.WriteLine(resultFloat);
        }
    }
}
