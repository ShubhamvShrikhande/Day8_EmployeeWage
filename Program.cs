using System;

namespace EmployeeWage
{
    internal class Program
    {
        Random rd = new Random();
       public static void Main(string[] args)
        {
            Program pg = new Program();
            pg.checkAttendance();


        }
        public void checkAttendance()
        {
            int Present = rd.Next(0, 2);
            if(Present == 1)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
