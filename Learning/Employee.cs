using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Employee
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string Lname {get;set;}

        private Employee() { }

        private Employee(int id, string fName, string lname)
        {
            Id = id;
            FName = fName;
            Lname = lname;
        }

        public static Employee Create (int id, string fName, string lname)
        {
            return   new Employee(id,fName,lname);
        }

        public string DisplayName()
        {
            return $"Id : {this.Id} , Name : {this.Lname} {this.Lname}";
        }
    }
}
