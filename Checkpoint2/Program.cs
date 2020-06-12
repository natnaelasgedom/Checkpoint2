using System;

namespace Checkpoint2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Natnael", 29);
            Company nike = new Company("Nike", 957);
            DateTime hireDate = new DateTime(); 
            hireDate = DateTime.Now;
            Employee employee = new Employee("Miriam", 25, hireDate, nike);
            Console.WriteLine(Employee.Describe(employee));
        }
    }
}
