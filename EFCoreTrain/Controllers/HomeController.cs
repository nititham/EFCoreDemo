using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFCoreTrain.Models;
using EFCoreTrain.Repositories;

namespace EFCoreTrain.Controllers
{
    public class HomeController : Controller
    {
        private readonly AuthorRepository authorRepository;
        public HomeController(AuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public string Contact()
        {
            ViewData["Message"] = "Your contact page.";

            var author = authorRepository.Get();
            var authorEndWithT = authorRepository.GetEndWith("t");
            authorRepository.Insert(new List<string> { "Yok4", "Yok5", "Yok6" });

            return author.ToString();
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
