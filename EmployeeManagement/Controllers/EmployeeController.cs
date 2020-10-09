
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
public class EmployeeController: Controller
{
    public ActionResult<string> Index()
    {
        // List<Employee> employees = new List<Employee>();
        var employee1 = new Employee()
        {
            FirstName= "Random",
            LastName= "Guy",
            Address = "NoLand",
            Salary= 00000

        };
        var employee2 = new Employee{FirstName= "Mark",LastName= "Pa",Address = "Ktm",Salary= 50000};
        var employee3 = new Employee{FirstName= "Azyt",LastName= "Pan",Address = "lalitpur",Salary= 30000};
        var employee4 = new Employee{FirstName= "Ajit",LastName= "Pand",Address = "bhaktapur",Salary= 15000};
        var employee5 = new Employee{FirstName= "Azit",LastName= "Pande",Address = "hetauda",Salary= 4500};
        var employee6 = new Employee{FirstName= "Ajeet",LastName= "Pandey",Address = "bhalubang",Salary= 21000};

        var employees = new List<Employee>{employee1,employee2,employee3,employee4,employee5,employee6};

       


        return View(employees);
    }
}

public class Employee
{
    public string FirstName {get; set;}

    public string LastName {get; set;}

    public string Address {get; set;}

    public char Gender {get; set;} = 'M';

    public double Salary {get; set;}
}