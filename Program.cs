using System;

namespace Bundle
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
