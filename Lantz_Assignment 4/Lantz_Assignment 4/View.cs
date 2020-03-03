using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lantz_Assignment_4
{
    class View
    {
        Random rand = new Random();



        public void Selection()
        {
            Console.WriteLine("What is your selection?");
        }

        public void Intro()
        {
            Console.WriteLine("This application will hold information about the employees that you have.");
            Console.WriteLine("You will be able to enter employees and display all employees.");
        }

        public void Menu()
        {
            Console.WriteLine("\n\t1. Enter New Employee");
            Console.WriteLine("\t2. View Employee List");
            Console.WriteLine("\t3. Remove Employee");
            Console.WriteLine("\t4. Exit App");
        }

        public string FirstName()
        {
            string input;
            Console.WriteLine("\nPlease enter the employee first name");
            return input = Console.ReadLine();
        }

        public string LastName()
        {
            string input;
            Console.WriteLine("\nPlease enter employee last name");
            return  input = Console.ReadLine();
        }

        public string JobTitle()
        {
            string input;
            Console.WriteLine("\nPlease enter the employee job title.");
            return input = Console.ReadLine();
        }

        public int CreateEmpNum()
        {
            int empNum = rand.Next(3500, 8000);
            return empNum;
        }

        public string Remove()
        {
            string input;
            Console.WriteLine("What is the last name of the employee you would like to remove?");
            return input = Console.ReadLine();
        }
       
        public bool EnterEmployee()
        {
            Console.WriteLine("\nEnter another employee?");
            Console.WriteLine("Enter [1] to enter another employee");
            Console.WriteLine("Enter [0] to exit to main menu");
            string input = Console.ReadLine();
            if (input == "0")
                return true;
            else
                return false;
        }
    }
}
