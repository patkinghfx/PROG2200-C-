namespace SchoolTracker
{
    enum Month
    {
        January = 0,
        February = 1,
        March = 2,
        April = 3,
        May = 4,
        June = 5,
        July = 6,
        August = 7,
        September = 8,
        October = 9,
        November = 10,
        December = 11,
    }
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {

            var adding = true;

            while (adding)
            {
                try
                {
                    var newStudent = new Student
                    {
                        Name = Util.Console.Ask("Student Name: "),

                        Grade = Util.Console.AskInt("Student Grade: "),

                        Birthday = (Month)Util.Console.AskInt("Student Birthday:\n Jan = 0 \n Feb = 1 \n March = 2 \n April = 3 \n May = 4 \n June = 5 \n July = 6 \n Aug = 7 \n Sept = 8 \n Oct = 9 \n Nov = 10 \n Dec = 11 \n"),

                        Address = Util.Console.Ask("Student Address: "),

                        Phone = Util.Console.AskInt("Student Phone Number: ")
                    };

                    students.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine("Student Count: {0}", Student.Count);

                    Console.WriteLine("Add another? y/n");

                    if (Console.ReadLine() != "y")
                        adding = false;
                }
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error adding student, Please try again");
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
        }

        static void Export()
        { foreach (var student in students)
            {
                switch (student.Birthday)
                {
                    case Month.January: Console.WriteLine("Born January");
                        break; 
                    case Month.February: Console.WriteLine("Born February");
                        break;
                    case Month.March: Console.WriteLine("Born March");
                        break;
                    case Month.April: Console.WriteLine("Born April");
                        break;
                    case Month.May: Console.WriteLine("Born May");
                        break;
                    case Month.June: Console.WriteLine("Born June");
                        break;
                    case Month.July: Console.WriteLine("Born July");
                        break;
                    case Month.August: Console.WriteLine("Born August");
                        break;
                    case Month.September: Console.WriteLine("Born September");
                        break;
                    case Month.October: Console.WriteLine("Born October");
                        break;
                    case Month.November: Console.WriteLine("Born November");
                        break;
                    case Month.December: Console.WriteLine("Born December");
                        break;
                }
            }

                }

        static void Import()
        {
            var importedStudent = new Student("Jenny", 86, 3, "address", 123456);
            Console.WriteLine(importedStudent.Name);
        }
    }

    class Teacher : Member
    {
        public string Subject;
    }
}

