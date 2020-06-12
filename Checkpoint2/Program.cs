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

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; protected set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }

    public class Company 
    {
        public string Name { get; set; }
        public int EmployeeCount { get; set; }

        public Company(string name, int employeeCount = 0)
        {
            Name = name;
            EmployeeCount = employeeCount;
        }
    }

    public class Employee : Person
    {
        public DateTime HireDate { get; set; }
        public Company MyCompany { get; set; }

        public Employee(string name, int age, DateTime hireDate, Company myCompany) : base(name, age)
        {
            HireDate = hireDate;
            MyCompany = myCompany;
            MyCompany.EmployeeCount++;
        }

        public static string Describe(Employee e)
        {
            return $"Company: {e.MyCompany.Name}\n" +
                $"Type: Employee\n" +
                $"Name: {e.Name}\n" +
                $"Age: {e.Age}\n" +
                $"HireDate: {e.HireDate}\n";
        }

    }
}
