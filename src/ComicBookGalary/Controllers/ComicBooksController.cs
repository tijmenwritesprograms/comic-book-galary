using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGalary.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {

            return Content("Hello from the Comic Book Controller!");
        }
    }
}