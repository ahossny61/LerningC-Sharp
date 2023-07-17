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

            Test t = new Test();


        }
    }

    public abstract class Test
    {
        public int x { set; get; }
        public abstract int y { set; get; }
        public void print()
        {
            Console.WriteLine("hi");
        }
        public abstract void Printf();
    }

    public class abstract_child : Test
    {
        public override int y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
