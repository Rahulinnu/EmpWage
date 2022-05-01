using System;
namespace EmpWage
{
    public class UC2
    {
        public UC2()
        {
            int empPresent = 1;
            int empHrs = 0;
            int empWage =0 ;
            int wage_Per_Hour = 20;            
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == empPresent)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
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
