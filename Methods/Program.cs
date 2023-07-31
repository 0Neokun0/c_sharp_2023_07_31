using System;
 namespace MyApplication
{
    class Methods
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }
        static void MyMethod2(string myText)
        {
            Console.WriteLine(myText);
            Console.Read();
        }
        static void Main(string[] args)
        {
            MyMethod();
            MyMethod2("I am called from a method");

        }
    }
}