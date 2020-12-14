using Microsoft.AspNetCore.Mvc;

namespace EMSApi.Controllers
{
    [Route("/test/getString")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [Route("[action]")]
        public List<Employee> GetEmployee()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id ="1", FirstName = "Azyt". " LastName" = "Pandey", Address = "Ktm"},
                 new Employee { Id ="1", FirstName = "Azyt". " LastName" = "Pandey", Address = "Ktm"}
            };

            return employyees;



        }

    }
}