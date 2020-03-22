using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace Lantz_Assignment_7
{
    class Controller
    {
        Tables table = new Tables();
        Info info = new Info();
 

        public void RunProgram()
        {
            table.BuildTable();
            string input;
           
            do
            {
                info.Menu();//Displays menu
                input = info.Selection();//Asks a user to make a selection and takes input

                Console.Clear();

                switch (input)
            {

                case "1":
                        Console.WriteLine("\n\nPlease enter a first name: ");

                        input = Console.ReadLine();

                        table.SearchDataBaseByName(input, 1);

                        info.PressEnter();

                        break;

                case "2":
                        Console.WriteLine("\n\nPlease enter a last name: ");

                        input = Console.ReadLine();

                        table.SearchDataBaseByName(input, 2);

                        info.PressEnter();

                        break;

                    case "3":
                        Console.WriteLine("\n\nPlease enter an Id number");

                        input = Console.ReadLine();

                        table.SearchDataBaseByName(input, 0);

                        info.PressEnter();

                        break;

                    case "4":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\nListing of all customers in database: ");
                        Console.ResetColor();

                        table.PrintAllNames();

                        info.PressEnter();

                        break;

                    case "5":
                        Console.WriteLine( "{0:f2}" , table.AverageAge());

                        info.PressEnter();

                        break;

                    case "6":
                        Console.WriteLine("\n\nPlease enter a max age to get a list of " +
                                                            "customers younger than that age: ");
                        input = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\nCustomers younger than {input}: ");
                        Console.ResetColor();

                        table.YoungerThan(input);

                        info.PressEnter();

                        break;

                    case "7":
                        Console.WriteLine("\n\nPlease enter a minimum age to get a list of " +
                                                                "customers older than that age: ");
                        input = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n\nCustomers older than {input}: ");
                        Console.ResetColor();

                        table.OlderThan(input);

                        info.PressEnter();

                        break;

                    case "8":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\nThis is the oldest customer in the database: ");
                        Console.ResetColor();

                        table.GetOldestCustomer();

                        info.PressEnter();

                        break;

                    case "9":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\nThis is the youngest customer in the database: ");
                        Console.ResetColor();

                        table.GetYoungestCustomer();

                        info.PressEnter();

                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\nInput cannot be empty, returning to main menu...");
                        Console.ResetColor();

                        break;
                }//End of switch

            } while (input != "10");
        }




    }//End of class
}//End of namespace
