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
        int totalWorkHouer;

        public Program(int wageHore, int dayHour, int dailyWage, int parttime, int totalwork, int totalhouer)
        {
            wagePHour = wageHore;
            fullDHour = dayHour;
            dailyEmpWage = dailyWage;
            partTime = parttime;
            totalworkday = totalwork;
            totalWorkHouer = totalhouer;
         }
        public void empWage()
        {
            int totalWage = 0;
            int day = 1;
            while (day <= 30 && totalworkday <= 20 && totalWorkHouer < 100)
            {
                switch (rd.Next(0, 3))
                {
                    case 1: dailyEmpWage = wagePHour * fullDHour;
                            totalWorkHouer += fullDHour;
                            totalWorkHouer++;
                    break;

                    case 2: dailyEmpWage = wagePHour * partTime;
                            totalWorkHouer += partTime;
                            totalWorkHouer++;

                    break;

                    default:
                     break;
                }
                totalWage += dailyEmpWage;
                day++; 
            }
             

        }
        public static void Main(string[] args)
        {
            Program pg = new Program(20, 8, 4 ,0,0 ,0);
            Console.WriteLine("total work houer is:" + pg.totalWorkHouer);
            Console.WriteLine("total working day is :" + pg.totalworkday);
            Console.WriteLine("wage or month is:" + pg.wagePHour);
            pg.empWage();
        }

    }
}
