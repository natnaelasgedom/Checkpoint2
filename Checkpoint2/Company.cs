namespace Checkpoint2
{
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
}
