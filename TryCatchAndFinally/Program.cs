using System;

namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
                Console.WriteLine("Parsed integer: " + userInputAsInt);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number you entered is too large or too small.");
            }
            catch (Exception)
            {
                Console.WriteLine("General exception, please enter the correct type next time.");
            }

            Console.ReadKey();
        }
    }
}
