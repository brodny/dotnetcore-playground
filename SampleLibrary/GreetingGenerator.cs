using System;

namespace SampleLibrary
{
    public class GreetingGenerator
    {
        public string GenerateGreeting(string name)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            string greeting = $"Hello, {name}!";

            return greeting;
        }
    }
}
