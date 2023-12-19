using Demo1Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Demo1Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /*
         Data transfer using variables from controller to view:

        1. ViewBag
        2. ViewData
        3. TempData         
         
         */
       
        //returns View specified in View method
        public IActionResult Index()
        {
            List<string> Empl = new List<string>();
            Empl.Add("Hello");
            Empl.Add("Mary");
            Empl.Add("Ruth");

            ViewBag.EmpName = "John Patrick";
            ViewData["EmpDesig"] = "HR";

            ViewBag.EmpDet = Empl;
            ViewData["EmpDetVD"] = Empl;

            TempData["EName"] = "Mary Curie";

            return View("NewMeth");
        }
        //Returns PartialView
        public PartialViewResult Index1()
        {
            return PartialView("PView");
        }
        //Redirect to different action methods within same controller
        public RedirectResult Redt()
        {
            return Redirect("Index1");
        }
        //Working of ViewResult
        public ViewResult NewMeth()
        {
            string name;
            if (TempData.ContainsKey("EName"))
            {
                name = TempData["Ename"].ToString();
                ViewBag.Name = name;
            }
            return View();
        }
        public ViewResult MD()
        {
            string name;
            if (TempData.ContainsKey("EName"))
            {
                name = TempData["Ename"].ToString();
                ViewBag.Name = name;
            }
            return View();
        }
        //Redirect to different action methods within same controller as well as different controllers
        public ActionResult RedToCont()
        {
            return RedirectToAction("Create","Employee");
        }
        //returns a content as a result
        public ContentResult ConRes()
        {
            return Content("<script>alert('I am a Content Result')</script>", "text/html");
        }
        //returns jsonresult
        public JsonResult JsRes()
        {
            bool isAdmin = false;

            string output = isAdmin ? "Welcome Hello" : "Welcome Team";

            return Json(output);

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