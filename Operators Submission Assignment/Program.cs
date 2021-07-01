using System;

namespace Operators_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            Employee obj2 = new Employee();
        }

        public static bool operator ==(obj1, obj2)
        { 

    Console.WriteLine(obj1 == obj2);
    }
}
