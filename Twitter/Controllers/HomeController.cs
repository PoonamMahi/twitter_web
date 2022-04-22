﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Twitter.Models;
using Twitter.DataAccess;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Twitter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DataContext _dataContext;

        public HomeController(ILogger<HomeController> logger,DataContext dataContext)
        {
            _logger = logger;
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> List()
        {
            var data = await _dataContext.RegisterModel.ToListAsync();
            return View(data);
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