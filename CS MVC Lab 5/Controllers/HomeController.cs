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
            if (ModelState.IsValid)
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
                        if(model.Y == 0)
                        {
                            ModelState.AddModelError("divByZero", "We don't divide by zero");
                            model.Result = double.NaN;
                        }
                        else
                            model.Result = model.X / model.Y;
                        break;
                }

                return View(model);
            }
            else
                return View();
        }
    }
}
