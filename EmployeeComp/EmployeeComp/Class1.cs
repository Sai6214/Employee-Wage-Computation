using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComp
{
    public class Class1
    {
        int isPartTime = 0;
        int isPresent = 1;
        int isFullTime = 2;
        int result;
        int totalSalary;
        int salary;
        int empHrs=1;
        int empRatePerHr = 20;
        int totalWorkingDays = 20;
        int totalWorkingHrs=100;
        int workingHr = 0;
        int workingDays = 0;
        Random random = new Random();
        public void Attendance()
        {
        int randomCheck = random.Next(2);

            if (randomCheck==isPresent)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public void DailyWages()
        {
            int randomCheck = random.Next(2);
            if (randomCheck == isPresent)
            {
                empHrs = 8;
                result = empRatePerHr * empHrs;
                Console.WriteLine("Employee is Present");
                Console.WriteLine("Employee Daily Wages =" + result);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("Emmployee wage =0 ");
            }
        }
        public void PartTime()
        {


            int randomCheck = random.Next(3);

            if (randomCheck == isPartTime)
            {
                Console.WriteLine("Employee work Half Day only");
                empHrs = 4;
            }
            else if (randomCheck == isFullTime)
            {
                Console.WriteLine("Employee work Full Day");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            Console.WriteLine("Todays Salary is : "+empRatePerHr * empHrs);
        }
        public void SwitchCase()
        {
            int randomCheck = random.Next(3);
            switch(randomCheck)
            {
                case 1:
                    empHrs = 8;
                    break;
                case 2:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;

            }
            Console.WriteLine("By Switch Case salary is : "+ empRatePerHr * empHrs);
        }
        public void WagesForMonth()
        { 
            for (int day=1;day<=totalWorkingDays;day++)
            {
                int randomCheck = random.Next(3);
                switch (randomCheck)
                {
                    case 1:
                        Console.WriteLine("Full Day : ");
                        empHrs = 8;
                        break;
                    case 2:
                        Console.WriteLine("Half Day : ");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Absent : ");
                        empHrs = 0;
                        break;
                }
                salary = (empRatePerHr * empHrs);
                totalSalary = (totalSalary + salary);
                Console.WriteLine( totalSalary );
            }
        }
        public void WorkingHrsAndDayForMonth()
        {
            while(workingHr<totalWorkingHrs || workingDays < totalWorkingDays )
            {
                workingDays++;
                int randomCheck = random.Next(3);
                switch(randomCheck)
                {
                    case 1:
                        Console.WriteLine("full day Present : ");
                        empHrs = 8;
                        break;
                    case 2:
                        Console.WriteLine("Half day Present : ");
                        break;
                    default:
                        Console.WriteLine("not Present : ");
                        break;      
                }
                workingHr = (workingHr + empHrs);
            }
            totalSalary = (workingHr * empRatePerHr);
            Console.WriteLine("Total Salary For Month = "+totalSalary);     
        }
    }
}
