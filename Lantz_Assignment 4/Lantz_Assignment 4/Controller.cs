using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lantz_Assignment_4
{
    class Controller
    {
        string input;
        View vw = new View();
        List list = new List();

        public void RunProgram()
        {
          
            do
            {
                
                vw.Menu();

                input = Console.ReadLine();

                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter a value");
                }
                if(input == "1")
                {
                    do
                    {
                        Employee emp = new Employee(vw.FirstName(), vw.LastName(), vw.CreateEmpNum(), vw.JobTitle());
                        list.AddToList(emp);
                    } while (!vw.EnterEmployee());

                    
                }
                if(input == "2")
                {
                    foreach (string name in list)
                    {
                        Console.WriteLine(name);
                    }

                }
                
                if(input == "3")
                {
                    list.RemovePerson(vw.Remove());
                    
                }

                if (input == "5")
                    Console.Clear();
            } while (input != "4");
        }






    }//End of class

}//End of namespace
