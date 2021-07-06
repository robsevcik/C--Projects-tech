using System;

namespace Parameters_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> obj1 = new Employee<string>();

            List<string> things = new List<string>();

            obj1.Things = new List<string> { "cat", "dog", "boy" };

            Employee<int> obj2 = new Employee<int>();

            obj2.Things = new List<int> { 5, 3, 523 };

            //loop through list with a for loop//
            for (int i = 0; i < List.Count; i++)
            {
                Console.WriteLine(List[i]);
            }
        }
    }

}
