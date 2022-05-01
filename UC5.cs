using System;
namespace EmpWage
{
    public class UC5
    {
        public UC5()
        {
            int empHrs = 0;
            int empWage = 0;
            int wage_Per_Hour = 20;
            int totWage = 0;
            Random random = new Random();
            for (int i = 1; i <= 20; i++)
            {
                int empCheck = random.Next(0, 3);


                switch (empCheck)
                {
                    case 0:
                        Console.WriteLine("Employee is Full time");
                        empHrs = 8;
                        break;

                    case 1:
                        Console.WriteLine("Employee is Part time");
                        empHrs = 4;
                        break;

                    default:
                        Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;

                }

                empWage = empHrs * wage_Per_Hour;
                Console.WriteLine("Employee wage = " + empWage);
                totWage = totWage + empWage;
            }

            Console.WriteLine("Total wage = " + totWage);
        
        }
    }
}
