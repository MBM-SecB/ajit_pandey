
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
public class EmployeeController: Controller
{
    public ActionResult<string> Index()
    {
        List<Employee> employees = new List<Employee>();
        var employee1 = new Employee
        {
            FirstName:"Mark",
            LastName:"Rober",
            Address:"Ktm",
            Salary:50000

        };

        return View();
    }
}

class Employee
{
    public string FirstName {get; set;}

    public string LastName {get; set;}

    public string Address {get; set;}

    public char Gender {get; set;} = 'M';

    public double Salary {get; set;}
}