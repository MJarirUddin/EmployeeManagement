using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            return Json(new {id =1, Name="abbo" });
        }
    }
}
//why inherit from controller, coz it will provide a much larger scope of API's(fuck'em xd) included to be used