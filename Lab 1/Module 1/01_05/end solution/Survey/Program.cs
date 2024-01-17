using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();

            Console.WriteLine("In what month were you born?");
            var month = Console.ReadLine();

            Console.WriteLine("Where were you born?");
            var birthPlace = Console.ReadLine();

            Console.WriteLine("What is your mother's name?");
            var momName = Console.ReadLine();

            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"You are {age} years old.");
            Console.WriteLine($"You were born in {month}");
            Console.WriteLine($"You were born in the city of {birthPlace}");
            Console.WriteLine($"Your mother's name is {momName}");
        }
    }
}
