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
                  
                  switch(empCheck)
                  {
                    case 1 :
                    EmpWage= partTimeHrs*wagePerHour;
                    Console.WriteLine("Part time employee wage is:" +EmpWage);
                    break;
                    case 2 :
                    EmpWage= FullTimeHrs*wagePerHour;
                    Console.WriteLine("Full time employee wage is:" +EmpWage);
                    break;
                    default :
                    EmpWage = 0;
                    Console.WriteLine("Employee is absent");
                    break;
                  }
         }
			}
   	}
}
  