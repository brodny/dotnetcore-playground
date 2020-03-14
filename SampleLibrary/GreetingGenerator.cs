using System;

namespace SampleLibrary
{
    public class GreetingGenerator
    {
        public string GenerateGreeting(string name)
        {
            string greeting = $"Hello, {name}!";

            return greeting;
        }
    }
}
