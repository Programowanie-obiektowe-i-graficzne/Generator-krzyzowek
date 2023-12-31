﻿using Microsoft.AspNetCore.Mvc;
using Projekt_krzyżówki.Models;
using System.Diagnostics;

namespace Projekt_krzyżówki.Controllers
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

        public IActionResult Autorzy()
        {
            return View();
        }
        public IActionResult Generator()
        {
            return View();
        }
        public IActionResult Opis()
        {
            return View();
        }
        public IActionResult Dodaj()
        {
            return View();
        }
        public IActionResult Lista()
        {
            return View();
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