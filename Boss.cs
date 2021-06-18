using System;

namespace company
{
    class Boss : Employee
    {
        public string CompanyCar {get; set;}

        public Boss(string companyCar, string lastName, string firstName, int salary) : base(lastName, firstName, salary)
        {
            this.CompanyCar = companyCar;
        }
        public void Lead()
        {
            Console.WriteLine("I'm the boss. My name is {0} {1}", FirstName, LastName);
        }
    }
}