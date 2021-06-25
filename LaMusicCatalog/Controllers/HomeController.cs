using LaMusicCatalog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LaMusicCatalog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMusicItemService _musicItemService;
        public HomeController(IMusicItemService musicItemService)
        {
            _musicItemService = musicItemService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            var musicItems = _musicItemService.GetAll();
            return View(musicItems);
        }
    }
}
