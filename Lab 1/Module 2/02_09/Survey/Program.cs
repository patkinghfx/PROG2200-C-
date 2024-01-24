using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            int month;
            while (!int.TryParse(GetMonthInput(), out month) || !ValidateMonth(month))
            {
                Console.WriteLine("Invalid month input. Please enter a valid month (1-12).");
            }

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            string zodiacSign = GetZodiacSign(month);
            Console.WriteLine($"Your zodiac sign is: {zodiacSign}");
        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(question))
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return question;
        }

        static string GetMonthInput()
        {
            Console.WriteLine("What month were you born in? (Enter a number between 1 and 12)");
            return Console.ReadLine();
        }

        static bool ValidateMonth(int month)
        {
            return month >= 1 && month <= 12;
        }

        static string GetZodiacSign(int month)
        {
            int day;
            while (true)
            {
                Console.WriteLine("What day of the month were you born on?");
                if (int.TryParse(Console.ReadLine(), out day) && day >= 1 && day <= 31)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid day input. Please enter a valid day of the month.");
                }
            }

            switch (month)
            {
                case 1:
                    return (day <= 19) ? "Capricorn" : "Aquarius";
                case 2:
                    return (day <= 18) ? "Aquarius" : "Pisces";
                case 3:
                    return (day <= 20) ? "Pisces" : "Aries";
                case 4:
                    return (day <= 19) ? "Aries" : "Taurus";
                case 5:
                    return (day <= 20) ? "Taurus" : "Gemini";
                case 6:
                    return (day <= 20) ? "Gemini" : "Cancer";
                case 7:
                    return (day <= 22) ? "Cancer" : "Leo";
                case 8:
                    return (day <= 22) ? "Leo" : "Virgo";
                case 9:
                    return (day <= 22) ? "Virgo" : "Libra";
                case 10:
                    return (day <= 22) ? "Libra" : "Scorpio";
                case 11:
                    return (day <= 21) ? "Scorpio" : "Sagittarius";
                case 12:
                    return (day <= 21) ? "Sagittarius" : "Capricorn";
                default:
                    return "Unknown Zodiac Sign";
            }
        }
    }
}