using LaMusicCatalog.Models;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index(string Select)
        {
            IEnumerable<MusicItem> musicItems;
            if (Select == null)
            {
                musicItems = _musicItemService.GetAll();
            }
            else
            {
                if (Select == "Notes")
                {
                    musicItems = _musicItemService.GetOnlyNotes();
                }
                else //if (Sheets == "Chords")
                {
                    musicItems = _musicItemService.GetOnlyChords();
                }
            }
            var musicItemsResult = musicItems
                .Select(result => new MusicItem
                {
                    Id = result.Id,
                    Author = result.Author,
                    Date = result.Date,
                    FileUrl = result.FileUrl,
                    ImageUrl = result.ImageUrl,
                    Title = result.Title
                });

            var model = new ListMusicItem()
            {
                MusicItems = musicItemsResult
            };
            return View(model);
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
