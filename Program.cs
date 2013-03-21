using System;

namespace Panel_Bundling
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the input string: ");
            var userInput = Console.ReadLine();
            new Bundler(userInput);
        }
    }
}
