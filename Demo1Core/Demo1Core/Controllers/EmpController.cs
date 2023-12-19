using Demo1Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo1Core.Controllers
{
    public class EmpController : Controller
    {
        private IEmp _Emps;

        public EmpController(IEmp Emps) 
        {                 
         _Emps = Emps;
        }

        public String Index()
        {
            return _Emps.GetEmp(2).EmpName;
           // return View();
        }
    }
}

//create a student class inside Model folder
//create a interface and write a method where it will fetch student
// create a class which will implement this fetch student method 
//( fetch student - should fetch students with mark=80)
//call it from controller and display it in the browser



