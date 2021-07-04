using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission_Assignment
{
    public class Employee
    {
        public int ID { get; set; }

                    //overloaded == pair//
        public static bool operator ==(Employee obj1, Employee obj2)
        {
        return obj1.ID == obj2.ID;
        }           //overloaded != pair//
        public static bool operator !=(Employee obj1, Employee obj2)
        {
        return obj1.ID != obj2.ID;
        }
    }
}
