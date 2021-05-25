﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportStore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IStoreRepository depo;
        public int pageSize = 2;

        public HomeController(ILogger<HomeController> logger, IStoreRepository _depo)
        {
            _logger = logger;
            depo = _depo;
        }

        public IActionResult Index(int urunSayfasi=1)
        {
            // İlk commit
            return View(depo.Urunler.OrderBy(p => p.UrunID)
                .Skip((urunSayfasi - 1) * pageSize)
                .Take(pageSize));
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
