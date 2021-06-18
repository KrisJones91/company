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

            Console.ReadKey();

        
        }
    }
}
