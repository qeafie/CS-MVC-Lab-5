using CS_MVC_Lab_5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CS_MVC_Lab_5.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
       public ActionResult Index(OperationModel model, string command)
        {
          
            switch (command)
            {
                case "add":
                    model.Result = model.X + model.Y;
                    break;

                case "sub":
                    model.Result = model.X - model.Y;
                    break;

                case "mul":
                    model.Result = model.X * model.Y;
                    break;

                case "div":
                    model.Result = model.X / model.Y;
                    break;
            }
            return View(model);
        }
    }
}
