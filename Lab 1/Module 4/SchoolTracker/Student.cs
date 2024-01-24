namespace SchoolTracker
{
    class Student : Member, IGraduate
    {
        static public int Count = 0;

        public int Grade;
        public Month Birthday;

        public Student()
        {

        }

        public Student(string name, int grade, int birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = (Month)birthday;
            Address = address;
            Phone = phone;
        }

        public void Graduate()
        {
            Console.WriteLine($"{Name}");
        }
    }
}
