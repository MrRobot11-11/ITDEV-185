using System;
using System.Collections.Generic;
using System.Text;

namespace Lantz_Assignment_7
{
    class Info
    {

        public void Menu()
        {
            Console.WriteLine("\n\n[1] Search by First Name");
            Console.WriteLine("[2] Search by Last Name");
            Console.WriteLine("[3] Search by ID Number");
            Console.WriteLine("[4] List All Customers");
            Console.WriteLine("[5] List Average Customer Age");
            Console.WriteLine("[6] List Customers Younger Than Certain Age");
            Console.WriteLine("[7] List Customers Older Than Certain Age");
            Console.WriteLine("[8] List Oldest Customer");
            Console.WriteLine("[9] List Youngest Customer");
            Console.WriteLine("[10] Exit the Program");
        }

        public string Selection()
        {
            string input;
            Console.WriteLine("\nPlease make a selection...");
            
           return input = Console.ReadLine();
           
        }


        public void PressEnter()
        {
            Console.WriteLine("\nPress any key to continue...");
           Console.ReadKey();
            Console.Clear();
        }
    }
}
