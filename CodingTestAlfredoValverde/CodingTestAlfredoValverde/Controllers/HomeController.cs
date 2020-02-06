using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CodingTestAlfredoValverde.Models;
using Newtonsoft.Json;

namespace CodingTestAlfredoValverde.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PersonaViewModel model)
        {
            if (ModelState.IsValid)
            {
                string filePath = $@"{System.IO.Directory.GetCurrentDirectory()}\Files\CodingTest.txt";

                List<PersonaViewModel> personas = new List<PersonaViewModel>();


                if (System.IO.File.Exists(filePath))
                {
                    string jsonText = System.IO.File.ReadAllText(filePath);
                    personas = JsonConvert.DeserializeObject<List<PersonaViewModel>>(jsonText);
                }
                personas.Add(model);
                System.IO.File.WriteAllText(filePath, JsonConvert.SerializeObject(personas));
            }
            return View();
        }

        [HttpGet]
        public string GetJson()
        {
            string filePath = $@"{System.IO.Directory.GetCurrentDirectory()}\Files\CodingTest.txt";
            if (System.IO.File.Exists(filePath))
            {
                return System.IO.File.ReadAllText(filePath);
            }
            return "";
        }
    }
}
