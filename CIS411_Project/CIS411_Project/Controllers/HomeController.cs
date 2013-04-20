using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CIS411_Project.Core.Models;
using CIS411_Project.Core.Services;


namespace CIS411_Project.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {

            IService service = new BookService();
            ICollection<Books> books = service.listBooks();
            return View(books);

           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}
