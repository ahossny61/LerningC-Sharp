using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Report
    {
        public delegate bool Condition(Employee emp) ; 
        public void SalaryWithAndPlus6000(Employee[] employees)
        {
            Console.WriteLine("The employees that more than 6000 salary :");
            foreach(Employee emp in employees)
            {
                if(emp.TotalSalary >= 6000)
                {
                    Console.WriteLine($"Name : {emp.Name} , it's salary = {emp.TotalSalary}");
                }
            }
            Console.WriteLine("\n");
        }

        public void SalaryBetween3000And5999(Employee[] employees)
        {
            Console.WriteLine("The employees that Between 3000 And 5999 salary :");
            foreach (Employee emp in employees)
            {
                if (emp.TotalSalary >= 3000 && emp.TotalSalary < 6000)
                {
                    Console.WriteLine($"Name : {emp.Name} , it's salary = {emp.TotalSalary}");
                }
            }
            Console.WriteLine("\n");
        }

        public void DelegateExample(Employee[] employees,string title , Condition condition)
        {
            Console.WriteLine(title);
            foreach (Employee emp in employees)
            {
                if (condition(emp))
                {
                    Console.WriteLine($"Name : {emp.Name} , it's salary = {emp.TotalSalary}");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
