using System;
namespace EmpWage
{
    public class UC6
    {
        public UC6()
        {
            int empHrs = 0;
            int empWage = 0;
            int wage_Per_Hour = 20;
            int totWage = 0;
            int i = 0, j = 0;
            int max_WorkingHrs = 0, max_WorkingDays = 0;
            Random random = new Random();
            while (max_WorkingHrs <= 100 && max_WorkingDays <= 19)
            {
                max_WorkingDays++;
                Console.WriteLine("Day" + max_WorkingDays);
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
                Console.WriteLine("Employee wage = " + empWage + "\n");
                totWage = totWage + empWage;
            }

            Console.WriteLine("Total wage = " + totWage);
        }
    }
}
