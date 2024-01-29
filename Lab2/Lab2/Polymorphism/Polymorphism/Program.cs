using Moq;
using System;
using System.Collections.Generic;
using IWorker;

namespace Polymorphism
{
    public class Employee : IWorker
    {
        public string CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = 40 * wage;
            string result = $"This ANGRY EMPLOYEE worked {weeklyHours} hrs. " +
                            $"Paid for 40 hrs at $ {wage}" +
                            $"/hr = ${salary}";
            Console.WriteLine("\n" + result + " \n");
            Console.WriteLine("---------------------------------------------\n");
            return result;
        }
    }

    public class Contractor : IWorker
    {
        public string CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = weeklyHours * wage;
            string result = $"This HAPPY CONTRACTOR worked {weeklyHours} hrs. " +
                            $"Paid for {weeklyHours} hrs at $ {wage}" +
                            $"/hr = ${salary} ";
            Console.WriteLine("\n" + result + " \n");
            return result;
        }
    }



    public class Program
    {
        private static void Main(string[] args)
        {
            const int hours = 55, wage = 70;
            //List<Employee> employees = Utils.GetEmployees();

            var mock = new Mock<Utils>();
            mock.Setup(m => m.GetMockWorkers()).Returns(() =>
             new List<IWorker> { new Contractor(), new Employee() });

            List<IWorker> workers = mock.Object.GetMockWorkers();

            foreach (var worker in workers)
            {
                worker.CalculateWeeklySalary(hours, wage);
            }
        }        
    }

    public class Utils {
        //public static List<Employee> GetEmployees()
        //{
        //    var someEmployee = new Employee();
        //    var someContractor = new Contractor();
        //    var everyone = new List<Employee> { someEmployee, someContractor };
        //    return everyone;
        //}

        public virtual List<IWorker> GetMockWorkers()
        {
            throw new NotImplementedException();
        }
    }
}
