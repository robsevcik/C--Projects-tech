using System;
using System.Collections.Generic;

namespace Parameters_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> obj1 = new Employee<string>();

          

            obj1.Things = new List<string> { "cat", "dog", "boy" };

            Employee<int> obj2 = new Employee<int>();

            obj2.Things = new List<int> { 5, 3, 523 };

            //loop through list with a for loop//
            for (int i = 0; i < obj1.Things.Count; i++)
            {
                Console.WriteLine(obj1.Things);
            }
            for (int c = 0; c < obj2.Things.Count; c++) 
            {
                Console.WriteLine(obj2.Things);
            }
            
        }
    }

}
