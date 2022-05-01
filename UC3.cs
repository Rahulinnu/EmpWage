using System;
namespace EmpWage
{
    public class UC3
    {
        public UC3()
        {
            int empPresent = 1;
            int empParttime = 2;
            int empHrs = 0;
            int empWage = 0;
            int wage_Per_Hour = 20;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == empPresent)
            {
                Console.WriteLine("Employee is Full time");
                empHrs = 8;
            }
            else if (empCheck == empParttime)
            {
                Console.WriteLine("Employee is Part time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            empWage = empHrs * wage_Per_Hour;
            Console.WriteLine("Employee wage = " + empWage);
        }
    }
}
