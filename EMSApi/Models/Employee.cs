using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Employee
{

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; }


    public char Gender { get; set; } = 'M';


    public double Salary { get; set; }

    

}