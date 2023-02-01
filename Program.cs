using System;
using System.Net.NetworkInformation;

namespace EmployeeWage
{
    internal class Program
    {
        Random rd = new Random();
        int wagePHour;
        int fullDHour;
        int dailyEmpWage;
        int partTime;
        int totalworkday;

        public Program(int wageHore, int dayHour, int dailyWage, int parttime, int totalwork)
        {
            wagePHour = wageHore;
            fullDHour = dayHour;
            dailyEmpWage = dailyWage;
            partTime = parttime;
            totalworkday = totalwork;
         }
        public void ceckAttendance()
        {
            int totalWage = 0;
            int day = 1;
            while (day <= 30 && totalworkday <= 20)
            {
                switch (rd.Next(0, 3))
                {
                    case 1: dailyEmpWage = wagePHour * fullDHour;
                        Console.WriteLine("emp is presnt  and wage is:" + dailyEmpWage);
                        break;

                    case 2: dailyEmpWage = wagePHour * partTime;
                        Console.WriteLine("emp is presnt  and wage is:" + dailyEmpWage);
                        break;

                    default:
                        Console.WriteLine("emp is absent and wage is:" + dailyEmpWage);
                        break;
                }
                totalWage += dailyEmpWage;
                day++; 
            }
             

        }
        public static void Main(string[] args)
        {
            Program pg = new Program(20, 8, 4 ,0,0);
            pg.ceckAttendance();
        }

    }
}
