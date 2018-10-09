using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeClasses
{
    class SalariedEmployee : Employee
    {
        /***********************
         Methods
         **********************/
        public override void WriteToConsole()
        {
            Console.WriteLine($"{EmployeeCode}: {FirstName} {LastName} has an annual salary of {AnnualSalary}.");
        }

        /**********************
         Properties
         *********************/
         public long AnnualSalary { get; set; }
    }
}
