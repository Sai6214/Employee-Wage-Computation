using System;

namespace EmployeeComp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Class1 check = new Class1();
            check.Attendance();
            check.DailyWages();
            check.PartTime();
            check.SwitchCase();
            check.WagesForMonth();
            check.WorkingHrsAndDayForMonth();
        }
    }
}
