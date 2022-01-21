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
          int EmpWage;
          // int empHrs=0;
        
                  Random random = new Random();
                  int empCheck = random.Next(0,3);

                  if(empCheck == 1)
                  {
                    // empHrs = 4;
                    EmpWage=wagePerHour*partTimeHrs;
                    // Console.WriteLine("Employee is present");
                    Console.WriteLine("Part time employee wage is:" +EmpWage);
                  }
                  else if(empCheck == 2)
                  {
                    // empHrs = 8;
                    EmpWage=wagePerHour*FullTimeHrs;
                    Console.WriteLine("Full time employee wage is:" +EmpWage);
                  }
                  else
                  {
                    Console.WriteLine("Employee is absent");  
                  }
         }
			}
   	}
}
  