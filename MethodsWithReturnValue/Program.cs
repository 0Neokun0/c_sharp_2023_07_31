using System;
using System.ComponentModel;

namespace MyApplication
{
    class Program
    {
        

        public static int Add(int x, int y) {  
            return x + y; 
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(15, 31));
            Console.WriteLine(Multiply(15, 31));
            Console.Read();
        }
    }
}