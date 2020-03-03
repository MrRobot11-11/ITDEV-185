using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lantz_Assignment_4
{
    class List : IEnumerable
    {

        List<Employee> MyList = new List<Employee>();

        public IEnumerator GetEnumerator()
        {
            foreach (Employee emp in MyList)
            {
                yield return emp.ToString();
                Console.WriteLine();
            }
        }


        public void RemovePerson(string name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                Employee remove = MyList.Find(a => a.LastName.Equals(name, StringComparison.InvariantCultureIgnoreCase));
                MyList.Remove(remove);
                
            }
            

        }


        public void AddToList(Employee emp)
        {
            MyList.Add(emp);
        }



    }//End of class
}
