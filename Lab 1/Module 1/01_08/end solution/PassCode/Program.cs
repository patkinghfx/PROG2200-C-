using System;

namespace PassCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = "secret";
            var entry = "";
            bool hasAuth = false;

            do
            {
                Console.WriteLine("What is the pass code?");
                entry = Console.ReadLine();

                switch (entry)
                {
                    case "secret":
                        Console.WriteLine("Authorized");
                        Console.WriteLine("Please enter your new pass code");
                        code = Console.ReadLine();
                        hasAuth = true;
                        break;

                    default:
                        Console.WriteLine("Unauthorized");
                        break;
                }
            } while (hasAuth == false);
        } 
    }
}
