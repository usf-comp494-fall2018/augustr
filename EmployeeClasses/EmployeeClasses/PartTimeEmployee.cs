using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeClasses
{
    class PartTimeEmployee : Employee
    {
        /**********************
         Methods
         *********************/
         public override void WriteToConsole()
        {
            Console.WriteLine($"{EmployeeCode}: {FirstName} {LastName} is a part time employee, and earns {HourlyRate} an hour.");
        }

        /**********************
         Properties
         *********************/
         public double HourlyRate { get; set; }
    }
}
