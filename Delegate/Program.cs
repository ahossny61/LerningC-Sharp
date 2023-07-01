
using Delegate;

var employees = new Employee[]
{
    new Employee
    {
        Id = 1,
        TotalSalary= 5869,
        Name = "Ahmed",
        Gender = "male"
    },
     new Employee
    {
        Id = 1,
        TotalSalary= 6899,
        Name = "Aml",
        Gender = "female"
    },
      new Employee
    {
        Id = 1,
        TotalSalary= 3325,
        Name = "Asd",
        Gender = "male"
    },
       new Employee
    {
        Id = 1,
        TotalSalary= 10000,
        Name = "Aid",
        Gender = "male"
    },
};

Report report = new Report();
report.SalaryWithAndPlus6000(employees);
report.DelegateExample(employees, "Employees that greater than 2000",(Employee emp)=>emp.TotalSalary > 2000);
report.DelegateExample(employees, "Employees that greater than 7000",  emp => emp.TotalSalary > 7000);

