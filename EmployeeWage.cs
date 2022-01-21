using System;

namespace CSharpAssignmentDay3
{
   public class EmployeeWage
   {
 		public static void EmployeeWageSolution()
			{
				{
          int partTime=1;
          int FullTime=2;
          int wagePerHour=20;
          int EmpWage=0;
          int empHrs=0;
        
                  Random random = new Random();
                  int empCheck = random.Next(0,3);

                  if(empCheck == partTime)
                  {
                    empHrs = 4;
                    EmpWage=wagePerHour*empHrs;
                    // Console.WriteLine("Employee is present");
                    Console.WriteLine("Part time employee wage is:" +EmpWage);
                  }
                  else if(empCheck == FullTime)
                  {
                    empHrs = 8;
                    EmpWage=wagePerHour*empHrs;
                    Console.WriteLine("Part time employee wage is:" +EmpWage);
                  }
                  else
                  {
                    empHrs = 0;
                    Console.WriteLine("Employee is absent");  
                  }
         }
			}
   	}
}
  