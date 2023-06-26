using System;

namespace Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(1,12,00001);

            Console.WriteLine(date.GetDate());

            Employee emp = Employee.Create(1,"Ahmed","Hosny");
            Console.WriteLine( emp.DisplayName());

        }
    }
}
