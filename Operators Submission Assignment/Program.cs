﻿using System;

namespace Operators_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            Employee obj2 = new Employee();
            //ID Property//
            obj1.ID = (5);
            obj2.ID = (6);

            Console.WriteLine(obj1 == obj2);
            Console.ReadLine();
        }

        
        

    }
}
