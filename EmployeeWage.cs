using System;

namespace CSharpAssignmentDay3
{
   public class EmployeeWage
   {
 		public static void EmployeeAttendanceCheck()
			{
				{
                  Random attendance = new Random();

                  if(attendance.Next(0, 2) == 1)
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
}
  