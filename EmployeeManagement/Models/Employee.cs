using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Employee
{

    public int Id {get; set;}

    [Required(ErrorMessage = "Firstname required")]
    [Display(Name = "First Name")]

    public string FirstName { get; set; }

    [Required(ErrorMessage = "Lastname required")]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Address required")]
    [Display(Name = "Address")]
    public string Address { get; set; }

    [Required(ErrorMessage = "Gender required")]
    [Display(Name = "Gender")]
    public char Gender { get; set; }

    [Required(ErrorMessage = "Salary required")]
    [Display(Name = "Salary")]
    public double Salary { get; set; }

    public Department Department {get; set;}

    public int DepartmentId {get; set;}

    
}