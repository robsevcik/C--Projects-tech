using System;

namespace Parsing_Enums_Submission_Assignment
{
    public class Program
    {

        static void Main(string[] args);
    }
    public enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }

    Console.WriteLine("enter the day of the week");

            Day = Console.ReadLine();

        string name = null;
    if(string.IsNullOrEmpty(name);
    {
    throw new SevcikCustomException("please enter a day of the week");
    }
    else
{
    Console.WriteLine("Day: " + name);

}
    Console.ReadLine();
}
public class SevcikCustomException: Exception
    public SevcikCustomException()
{

}
public SevcikCustomException(string message) : base(message)
    {

}
public SevcikCustomException(string message,Exception innerexception) : base(message, innerexception)
    {

}

 
}
}






