using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.Linq;

namespace Lantz_Assignment_7
{
    class Tables 
    {
      
        //private System.Data.DataSet dataset;

        DataTable dt = new DataTable("Customers");//Create table

        //Builds table and enters values
        public DataTable BuildTable()
        {
            //Creating columns for the table
            dt.Columns.Add("ID", typeof(Int32));
            dt.Columns.Add("FIRSTNAME", typeof(string));
            dt.Columns.Add("LASTNAME", typeof(string));
            dt.Columns.Add("ADDRESS", typeof(string));
            dt.Columns.Add("AGE", typeof(Int32));

            //Creating primary key for table
            DataColumn[] keys = new DataColumn[1];
            keys[0] = dt.Columns[0];
            dt.PrimaryKey = keys;
            
            //Adding data to the table
            dt.Rows.Add(1234, "John", "Smith", "123 Fake St", 35);
            dt.Rows.Add(3456, "Mary", "Johnson", "755 North Ave", 28);
            dt.Rows.Add(4782, "Jeff", "Sampson", "789 Lincoln Ave", 32);
            dt.Rows.Add(8579, "Mike", "Smith", "7225 Mequon Rd", 46);
            dt.Rows.Add(8952, "Larry", "Bird", "4568 Boston Blvd", 78);
            dt.Rows.Add(9987, "Leroy", "Brown", "525 Greenfield", 22);
            dt.Rows.Add(7855, "Lisa", "Simpson", "456 Springfield Ln", 88);
            dt.Rows.Add(2566, "Mary", "Green", "8266 Capital Dr", 56);
            dt.Rows.Add(7555, "Lois", "Griffin", "7899 Becher Ave", 37);

            return dt;
        }//End of BuildTable()

        //Prints list of all customers in datatable
        public void PrintAllNames()
        {
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nId" + "\tName" + "\t\t\tAddress" + "\t\t\tAge");
            Console.ResetColor();

            foreach (DataRow o in dt.Select("", "firstname asc"))
            {
                Console.WriteLine(o["ID"] + "\t" + o["FIRSTNAME"] + "\t" + o["LASTNAME"]
                                                            + "\t\t" + o["ADDRESS"] + "\t\t" + o["AGE"]);
            }
        }
        
        //To search datatable by Id number, enter 0 for index
        //To search datatable by first name, enter 1 for index
        //To search datatable by last name, enter 2 for index
        public void SearchDataBaseByName(string name, int index)
        {
            try
            {
                //Check if name exists in datatable
                if (dt.Select().Any(e => e.ItemArray[index].ToString() ==
                  name.First().ToString().ToUpper() + name.Substring(1)))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nId" + "\tName" + "\t\t\tAddress" + "\t\t\tAge");
                    Console.ResetColor();

                    //Print all customers with first name that user inputs
                    foreach (DataRow d in dt.Select().Where(e => e.ItemArray[index].ToString() ==
                            name.First().ToString().ToUpper() + name.Substring(1)))
                    {
                        Console.WriteLine(d["ID"] + "\t" + d["FIRSTNAME"] + "\t" + d["LASTNAME"]
                                                                + "\t\t" + d["ADDRESS"] + "\t\t" + d["AGE"]);
                    }
                }
                else//If name doesn't exist
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That name does not exist in the database.");
                    Console.ResetColor();
            }
            catch (Exception e)//If no name is entered
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entry cannot be emtpy");
                Console.ResetColor();
            }
        }// End of SearchDataBase()
      
        //Gets average age of customers in datatable
        public double AverageAge()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nAverage age for all customers: ");
            Console.ResetColor();

            var avgAge = dt.Select().Average(e => (int)e.ItemArray[4]);

            return avgAge;
        }

        //Prints list of customers younger than user input from datatable
        public void YoungerThan(string input)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nId" + "\tName" + "\t\t\tAddress" + "\t\t\tAge");
                Console.ResetColor();

                foreach (DataRow d in dt.AsEnumerable().Where(x => Convert.ToInt32(x.ItemArray[4]) < Convert.ToInt32(input)))
                {
                    Console.WriteLine(d["ID"] + "\t" + d["FIRSTNAME"] + "\t" + d["LASTNAME"]
                                                                + "\t\t" + d["ADDRESS"] + "\t\t" + d["AGE"]);
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input cannot be empty");
                Console.ResetColor();
            }
        }

        //Prints list of customers younger than user input from datatable
        public void OlderThan(string input)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nId" + "\tName" + "\t\t\tAddress" + "\t\t\tAge");
                Console.ResetColor();

                foreach (DataRow d in dt.AsEnumerable().Where(x => Convert.ToInt32(x.ItemArray[4]) > Convert.ToInt32(input)))
                {
                    Console.WriteLine(d["ID"] + "\t" + d["FIRSTNAME"] + "\t" + d["LASTNAME"]
                                                                + "\t\t" + d["ADDRESS"] + "\t\t" + d["AGE"]);
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input cannot be empty");
                Console.ResetColor();
            }
        }

        //Gets age of oldest customer and prints all information to screen
        public void GetOldestCustomer()
        {
            //Get age of oldest person from column 'age'
            var max = dt.AsEnumerable().Max(e => Convert.ToInt32(e.ItemArray[4]));
            
            //Use max age to get customer information from datatable
            var row = dt.AsEnumerable().Where(x => x.Field<int>("age") == max).FirstOrDefault();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nId" + "\tName" + "\t\t\tAddress" + "\t\tAge");
            Console.ResetColor();

            Console.WriteLine(row["ID"] + "\t" + row["FIRSTNAME"] + "\t" + row["LASTNAME"]
                                                                + "\t" + row["ADDRESS"] + "\t" + row["AGE"]);

            //var maxw = dt.Rows.Cast<DataRow>().Max(r => r.Field<int>("age"));
            //Console.WriteLine(maxw);

        }

        //Gets age of oldest customer and prints all information to screen
        public void GetYoungestCustomer()
        {
            //Get age of youngest person from column 'age'
            var min = dt.AsEnumerable().Min(e => Convert.ToInt32(e.ItemArray[4]));

            //Use min age to get customer information from datatable
            var row = dt.AsEnumerable().Where(x => x.Field<int>("age") == min).FirstOrDefault();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nId" + "\tName" + "\t\t\tAddress" + "\t\tAge");
            Console.ResetColor();

            Console.WriteLine(row["ID"] + "\t" + row["FIRSTNAME"] + "\t" + row["LASTNAME"]
                                                                + "\t" + row["ADDRESS"] + "\t\t" + row["AGE"]);
            
        }
        //public void test(string input)
        //{
        //    try
        //    {
        //        var products = dt.AsEnumerable().Where(x => x.Field<string>("FirstName") == input).FirstOrDefault();

        //        Console.WriteLine(products["Firstname"]);
        //    }
        //    catch (NullReferenceException e)
        //    {

        //        Console.WriteLine("Person doesn't exist");
        //    }
        //}

    }//End of class
}//End of namespace
