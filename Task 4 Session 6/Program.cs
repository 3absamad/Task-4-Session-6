using Common;
using System.Reflection;
namespace Task_4_Session_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] EmpArr =
        {
            new Employee(
                1, "Ahmed", SecurityLevel.DBA, 25000m,
                new HiringDate(15, 3, 2022), 'M'),

            new Employee(
                2, "Sara", SecurityLevel.Guest, 12000m,
                new HiringDate(10, 7, 2023), 'F'),

            new Employee(
                3, "Omar", SecurityLevel.SecurityOfficer, 35000m,
                new HiringDate(1, 1, 2020), 'M')
        };

            Console.WriteLine("Employees");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");

            foreach (Employee employee in EmpArr)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
