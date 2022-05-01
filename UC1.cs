using System;
namespace EmpWage
{
    public class UC1
    {
        public UC1()
        {
            int empPresent = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == empPresent) 
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
