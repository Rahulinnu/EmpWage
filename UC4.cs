using System;
namespace EmpWage
{
    public class UC4
    {
        public UC4()
        {
            int empHrs = 0;
            int empWage = 0;
            int wage_Per_Hour = 20;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch(empCheck)
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

        }
    }
}
