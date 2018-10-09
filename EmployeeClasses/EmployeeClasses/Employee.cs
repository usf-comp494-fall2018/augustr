using System;

namespace EmployeeClasses
{
    public class Employee
    {
        /***************************
         Constructor
         **************************/
        public Employee()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            EmployeeCode = string.Empty;
            DateHired = DateTime.Now;
        }

        /***************************
         Methods
         **************************/
        public virtual void WriteToConsole()
        {
            Console.WriteLine($"{FirstName} {LastName} was hired on {DateHired:MM/dd/yyyy}, and has the code {EmployeeCode} registered to him.");
        }

        /***************************
         Properties
         **************************/

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime DateHired { get; set; }
    }

}