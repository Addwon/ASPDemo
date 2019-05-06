using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "John", LastName = "Doe", Age = 28 });
            people.Add(new PersonModel { FirstName = "Alan", LastName = "Smith", Age = 46 });
            people.Add(new PersonModel { FirstName = "Sarah", LastName = "Connor", Age =35 });
            people.Add(new PersonModel { FirstName = "Tom", LastName = "Lee", Age = 64 });

            return View(people);
        }
    }
}