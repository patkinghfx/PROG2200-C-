using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in your class?");
            var studentCount = int.Parse(Console.ReadLine());

            var students = new string[studentCount, 2];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write("Student Name: ");
                students[i, 0] = Console.ReadLine();

                Console.Write("Student Grade: ");
                students[i, 1] = Console.ReadLine();
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", students[i, 0], students[i, 1]);
            }
        }
    }
}
