using LaMusicCatalog.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaMusicCatalog.Controllers
{
    public class PersonalAreaController : Controller
    {
        private readonly ApplicationDbContext _db;
        UserManager<ApplicationUser> _userManager;
        public PersonalAreaController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            var userName = User.Identity.Name;

            List<UsersItems> UsersItemsFavMus = _db.UsersItems.Where(ap => ap.ApplicationUserName == userName).ToList();

            List<int> Ids = new List<int>();

            foreach (var item in UsersItemsFavMus)
            {
                Ids.Add(item.MusicItemId);
            }

            List<MusicItem> ListFavMusics = new List<MusicItem>();

            foreach (var item in Ids)
            {
                MusicItem obj = _db.MusicItems.Where(i => i.Id == item).FirstOrDefault();
                ListFavMusics.Add(obj);
            }
            return View(ListFavMusics);
        }

        [Authorize]
        public IActionResult Add(int Id)
        {
            var userName = User.Identity.Name;
            
            var obj = new UsersItems
            {
                ApplicationUserName = userName,
                MusicItemId = Id
            };

            List<int> Ids = new List<int>();

            var o = _db.UsersItems.Where(a => a.ApplicationUserName == obj.ApplicationUserName);

            foreach (var item in o)
            {
                Ids.Add(item.MusicItemId);
            }

            if (!(Ids.Contains(obj.MusicItemId)))
            {
                _db.UsersItems.Add(obj);
                _db.SaveChanges();
            }

            return RedirectToAction("Index", "PersonalArea");
        }

        [Authorize]
        public IActionResult Delete(int? id)
        {
            var obj = _db.UsersItems.Where(i => i.MusicItemId == id).FirstOrDefault();
            if (obj == null)
            {
                return NotFound();
            }

            _db.UsersItems.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index", "PersonalArea");

        }
    }
}