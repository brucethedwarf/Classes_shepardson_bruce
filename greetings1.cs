using System;

namespace Classes_shepardson_bruce
{
    class Greetings
    {
        // Method that prints a welcome message
        public void Welcome()
        {
            Console.WriteLine("Hello, traveler! Welcome.");
        }

        // Method that prints a personalized greeting with the provided name
        public void Hello(string name)
        {
            Console.WriteLine($"{name}, thank you for joining us today!");
        }
    }
}
