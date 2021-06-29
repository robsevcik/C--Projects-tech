using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Submission_Assignment
{
   public class Employee: Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine(Firstname + " " + Lastname);
        }
        IQuittable obj1 = new Employee();
        
        public void Quit()
        {
            Console.WriteLine("test text1");
        }
       
    }
}
