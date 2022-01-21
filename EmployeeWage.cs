using System;

namespace CSharpAssignmentDay3
{
   public class EmployeeWage
   {
 		public static void EmployeeWageSolution()
			{
				{
          int partTimeHrs=4;
          int FullTimeHrs=8;
          int wagePerHour=20;
          int workingDayPerMonth = 20;
          int EmpWagePerDay;
          int EmpWagePerMonth;
          // int empHrs=0;
        
                  Random random = new Random();
                  int empCheck = random.Next(0,3);
                  
                  switch(empCheck)
                  {
                    case 1 :
                    EmpWagePerDay= partTimeHrs*wagePerHour;
                    EmpWagePerMonth=EmpWagePerDay*workingDayPerMonth;
                    Console.WriteLine("Part time employee wage is:" +EmpWagePerDay);
                    Console.WriteLine("Part time employee wage per month is:" +EmpWagePerMonth);
                    break;

                    case 2 :
                    EmpWagePerDay= FullTimeHrs*wagePerHour;
                    EmpWagePerMonth=EmpWagePerDay*workingDayPerMonth;
                    Console.WriteLine("Full time employee wage is:" +EmpWagePerDay);
                    Console.WriteLine("Full time employee wage per month is:" +EmpWagePerMonth);
                    break;

                    default :
                    EmpWagePerMonth = 0;
                    Console.WriteLine("Employee is absent");
                    break;
                  }
         }
			}
   	}
}
  