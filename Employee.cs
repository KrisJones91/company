using System;

namespace company
{
    class Employee
    {
        public string LastName {get; set;}
        public string FirstName {get; set;}
        public int Salary {get; set;}
        public Employee(string firstName, string lastName, int salary)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Salary = salary;
        }
        
        public Employee(){}

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