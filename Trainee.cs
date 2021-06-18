using System;

namespace company
{
    class Trainee : Employee
    {
        public int WorkingHours {get; set;}
        public int SchoolHours {get; set;}
        
        public Trainee(int workingHours, int schoolHours, string lastName, string firstName, int salary) : base(lastName, firstName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("I'm learning from {0} hours!", SchoolHours);
        }

    }
}