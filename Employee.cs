using System;

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

        public void Work()
        {
            Console.WriteLine("I'm working");
        }

        public void Break()
        {
            Console.WriteLine("I'm on a break!");
        }
    }
}