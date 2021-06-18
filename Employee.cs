namespace company
{
    class Employee
    {
        public string Name {get; set;}
        public string FirstName {get; set;}
        public int Salary {get; set;}
        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }
    }
}