using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageBYArry
{
    public class Attendance
    {
        public void  attendance()
        {
         Random obj = new Random(); 
         int check =obj.Next(0,2);

            if (check==0) 
            {
                Console.WriteLine("absent");
            }
            else 
            {
                Console.WriteLine("prsent");
            }
        
        
        }
    }
}
