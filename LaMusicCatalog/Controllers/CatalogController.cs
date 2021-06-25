using LaMusicCatalog.Models;
using Microsoft.AspNetCore.Mvc;
using ReflectionIT.Mvc.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaMusicCatalog.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IMusicItemService _musicItemService;
        public CatalogController(IMusicItemService musicItemService)
        {
            _musicItemService = musicItemService;
        }
        public IActionResult Index(string Select, int pageIndex = 1)
        {
            var query = _musicItemService.GetAll();
            var mod = PagingList.Create(query, 4, pageIndex);
            return View(mod);
        }


        public IActionResult Detail(int id)
        {
            var sheetItem = _musicItemService.GetById(id);

            var model = new MusicItem
            {
                Id = sheetItem.Id,
                Author = sheetItem.Author,
                Date = sheetItem.Date,
                Title = sheetItem.Title,
                FileUrl = sheetItem.FileUrl,
                ImageUrl = sheetItem.ImageUrl
            };
            return View(model);
        }
    }
}
