using System;

namespace Lambda_Submission_Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> employee = new List<string>();


            employee.Add("Joe" + "Swanson" + 1);
            employee.Add("Joe" + "Strummer" + 2);
            employee.Add("Joe" + "Johnson" + 3);
            employee.Add("Ian" + "Curtis" + 4);
            employee.Add("Ian" + "Mcay" + 5);
            employee.Add("Nicky" + "Six" + 6);
            employee.Add("Nick" + "Mars" + 7);
            employee.Add("Tommy" + "Lee" + 8);
            employee.Add("Vince" + "Neil" + 9);
            employee.Add("Brandon" + "Lee" + 10);

            Console.WriteLine(employee);

            foreach (string Joe in employee)
            {
                Console.WriteLine(Joe);

            }

            string count = employee.count(x => x.employee == employee.Joe);

            List<int> new List = employee.where(x => x > 5).ToList;
        }
    }
}
