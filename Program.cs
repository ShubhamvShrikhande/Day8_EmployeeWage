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

        public Program(int wageHore, int dayHour, int dailyWage, int parttime)
        {
            wagePHour = wageHore;
            fullDHour = dayHour;
            dailyEmpWage = dailyWage;
            partTime = parttime;
        }
        public void ceckAttendance()
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
                        Console.WriteLine("emp is absent and wage is:"+dailyEmpWage);
                break;
            }
        }
        public static void Main(string[] args)
        {
            Program pg = new Program(20, 8, 4 ,0);
            pg.ceckAttendance();
        }

    }
}
