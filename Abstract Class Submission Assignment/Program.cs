using System;

namespace Abstract_Class_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee obj1 = new Employee();

            employee.firstName = "Sample";
            employee.lastName = "Student";

            obj1.SayName();

           
        }
    }
}
