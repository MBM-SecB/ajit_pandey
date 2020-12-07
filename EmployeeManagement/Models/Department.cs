using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Department
{
    public int Id {get; set;}

    [Required(ErrorMessage = "Department Name required")]
    [Display(Name = "Department Name")]

    public string DepartmentName { get; set; }

    [Required(ErrorMessage = "Department Id required")]
    [Display(Name = "Department Id")]
    public string DepartmentId { get; set; }

    public string Location { get; set; }

    public string Description { get; set; }

    public DateTime CreatedDate { get; set; }

    
}