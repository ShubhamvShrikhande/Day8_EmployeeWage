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
            int present = rd.Next(0, 3);
            if (present == 1)
            {
                dailyEmpWage = wagePHour * fullDHour;
                {
                    Console.WriteLine("emp is presnt and is wage is:" + dailyEmpWage);
                }
                if (present == 2)
                {
                    dailyEmpWage = wagePHour * partTime;
                    Console.WriteLine("emp is presnt in hafe day and is wage is:" + dailyEmpWage);
                }
                else
                {
                    Console.WriteLine("emp is absent and is wage is:" + dailyEmpWage);
                }
            }
        }
        public static void Main(string[] args)
        {
            Program pg = new Program(20, 8, 4 ,0);
            pg.ceckAttendance();
        }

    }
}
