using Microsoft.AspNetCore.Mvc;
using MVC_Demo2.Models;
using System.Runtime.CompilerServices;

namespace MVC_Demo2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentList()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Rollno=1,Name="Nilesh",City="Paranda"},
                new Student() {Rollno=2,Name="Sanket",City="Pune"},
                new Student() {Rollno=3,Name="Pankaj",City="Uruli"},
                new Student() {Rollno=4,Name="Gitish",City="Mumbai"},
                new Student() {Rollno=5,Name="Sagar",City="Solapur"}

            };
            ViewData["list"]=students;

            return View();
        }
    }
}
