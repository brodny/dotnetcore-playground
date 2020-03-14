using System;
using SampleLibrary;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Lukasz";

            GreetingGenerator generator = new GreetingGenerator();

            string greeting = generator.GenerateGreeting(myName);

            Console.WriteLine(greeting);
        }
    }
}
