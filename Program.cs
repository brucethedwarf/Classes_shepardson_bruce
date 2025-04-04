using System;

namespace Classes_shepardson_bruce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Greetings class
            Greetings greetings = new Greetings();

            // Call the Welcome method
            greetings.Welcome();
            Console.WriteLine("what is your name squire?");
             string userName = Console.ReadLine();
            // Call the Hello method with a name as argument
            greetings.Hello(userName);
        }   
    }
}
