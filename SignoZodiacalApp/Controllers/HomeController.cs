using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SignoZodiacalApp.Models;
using System;
using Application.Services;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Application.ModelView;

namespace SignoZodiacalApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GetZodiacSign service;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            service = new GetZodiacSign();
        }
        public IActionResult Index(ZodiacModelView vm)
        {
            return View(vm);
        }

        [HttpPost]
        public IActionResult GetZodiacSign(ZodiacModelView vm)
        {
            vm.sign = service.GetSign(vm.month, vm.day);
            return Index(vm);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
