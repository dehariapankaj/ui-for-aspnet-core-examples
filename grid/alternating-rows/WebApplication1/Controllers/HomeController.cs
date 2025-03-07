﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public static ICollection<Student> students = new List<Student>();
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public HomeController()
        {
            var names = new List<string> { "John", "Jane", "Jeremy", "James" };
            var lastNames = new List<string> { "Hammont", "Clarkson", "May", "Hennethon" };
            var random = new Random();
            if (students.Count == 0)
            {
                for (int i = 1; i < 50; i++)
                {
                    students.Add(new Student
                    {
                        Age = random.Next(1, 20),
                        Birthday = new DateTime(random.Next(1950, 2018), random.Next(1, 12), random.Next(1, 27)),
                        FirstName = names[random.Next(0, 4)],
                        LastName = lastNames[random.Next(0, 4)],
                        Id = i
                    });
                }
            }
        }

        public ActionResult GetStudents([DataSourceRequest] DataSourceRequest request)
        {

            return Json(students.ToDataSourceResult(request));
        }

        public ActionResult EditStudent(Student student)
        {
            students.Where(x => x.Id == student.Id).Select(x => student);

            return Json(student);
        }

        public ActionResult CreateStudent(Student student)
        {
            student.Id = students.Count + 1;
            students.Add(student);

            return Json(student);
        }

        public ActionResult DestroyStudent(Student student)
        {
            students.Remove(students.First(x => x.Id == student.Id));

            return Json(student);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
