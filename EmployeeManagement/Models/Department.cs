using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Department
{
    public int Id {get; set;}

    [Required(ErrorMessage = "Department Name required")]
    [Display(Name = "Department Name")]

    public string DepartmentName { get; set; }

    [Required(ErrorMessage = "Department Code required")]
    [MinLength(5)]
    [Display(Name = "Department Code")]
    public string DepartmentCode { get; set; }

    public string Location { get; set; }

    public string Description { get; set; }

    public DateTime CreatedDate { get; set; }

    public List<Employee> Employees {get; set;}

    
}