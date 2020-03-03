using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lantz_Assignment_4
{
    class Employee : Person
    {
        
        private int empNumber;
        private string jobTitle;
        
        
        public Employee(string firstName, string lastName, int empNumber, string jobTitle)
             : base (firstName, lastName)
        {
            EmpNumber = empNumber;
            JobTitle = jobTitle;
        }
      
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public int EmpNumber { get => empNumber; set => empNumber = value; }

        public override string ToString()
        {
            return base.ToString() + "\nEmployee Number: " + EmpNumber +
                                                            "\nJob Title: " + jobTitle;
        }

     

    }//End of class
}
