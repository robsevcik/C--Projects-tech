using System;

namespace Methods_and_objects_submission_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            //instantiate and initialize an employee object//
            employee.Firstname = "Sample";
            employee.Lastname = "Student";
            //calling the method//
            employee.SayName();

        }
    }
}
