using Microsoft.AspNetCore.Mvc;
using MVC_Demo2.Models;

namespace MVC_Demo2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmpList()
        {
            List<Employee> employee = new List<Employee>
            {
            new Employee { Id = 1,Name="Soham",Dept="Hr",PhoneNumber=9575849302},
              new Employee { Id = 2,Name="Nilesh",Dept="Manager",PhoneNumber=9575849302},
                new Employee { Id = 3,Name="Rupesh",Dept="Hr",PhoneNumber=9575849302},
                  new Employee { Id = 4,Name="Ganesh",Dept="Testing",PhoneNumber=9575849302},
                    new Employee { Id = 5,Name="Amar",Dept="Developer",PhoneNumber=9575849302}
            };
            ViewData["list"] = employee;
            return View();
        }
    }
}
