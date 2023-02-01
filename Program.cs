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

        public Program(int wageHore,int dayHour,int dailyWage)
        {
            wagePHour =wageHore;
            fullDHour = dayHour;
            dailyEmpWage = dailyWage;  
        }
        public void ceckAttendance()
        {
            int present = rd.Next(0, 2);
            if(present == 1)
            {
                dailyEmpWage = wagePHour * fullDHour;
                {
                    Console.WriteLine("emp is presnt and is wage is:" + dailyEmpWage);
                }
            }
        }
        public static void Main(string[] args)
        {
            Program pg = new Program(20, 8, 0);
            pg.ceckAttendance();
        }
        
    }
}
