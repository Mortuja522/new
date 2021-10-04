using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_WebApplication.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }



    }
}