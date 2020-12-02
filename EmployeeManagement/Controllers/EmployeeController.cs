
using System.Linq;
using EmployeeManagement.Data;
using Microsoft.AspNetCore.Mvc;
public class EmployeeController: Controller
{

    private EMSContext db;

    public EmployeeController(EMSContext _db)
    {
        db = _db;
    }
    public ActionResult<string> Index()
    {
        // var employees = Employee.GetEmployees();

        // List<Employee> employees = new List<Employee>();
        
        var employees = db.Employees.ToList();

        return View(employees);
    }

    public ActionResult Detail(int id)
    {
       var employee =  db.Employees.Find(id);
        return View(employee);
    }

    public ActionResult Add()
    {
        return View();
    }

    public ActionResult Edit(int id)
    {
        var employee = db.Employees.Find(id);
        return View(employee);
    }

    [HttpPost]
    public ActionResult Add(Employee employee)
    {
        db.Employees.Add(employee);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
     [HttpPost]
    public ActionResult Delete(int id)
    {
        var employee = db.Employees.Find(id);
        db.Employees.Remove(employee);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
    [HttpPost]
    public ActionResult Edit(Employee employee)
    {
         db.Employees.Attach(employee);
        
        db.Employees.Update(employee);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
}

 