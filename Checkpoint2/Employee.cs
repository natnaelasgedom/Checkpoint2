using System;

namespace Checkpoint2
{
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
                $"HireDate: {e.HireDate}";
        }

    }
}
