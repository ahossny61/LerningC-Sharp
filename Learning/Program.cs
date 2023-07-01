using System;
using System.ComponentModel.DataAnnotations;

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

            var ip = new IP(192, 162, 0, 0);
            ip[3] = 15;
            Console.WriteLine(ip.GetIP);

            var ip2 = new IP("192.168.1.0");
            Console.WriteLine(ip2.GetIP);

        }
    }
}
