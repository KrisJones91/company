using System;

namespace company
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Mike = new Employee("Jones", "Mike", 40000);
            Mike.Work();
            Mike.Break();

            Boss Kris = new Boss("Lambo", "Jones", "Kris", 1000000);
            Kris.Lead();


            Trainee Robert = new Trainee(32, 9, "Gumeny", "Robert", 100);
            Robert.Learn();
            Robert.Work();
            Console.ReadKey();

        
        }
    }
}
