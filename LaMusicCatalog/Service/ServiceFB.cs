using LaMusicCatalog.Models;
using LaMusicCatalog.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LaMusicCatalog.Service
{
    public class ServiceFB : IServiceFB
    {
        private readonly ApplicationDbContext _db;

        public ServiceFB(ApplicationDbContext db)
        {
            _db = db;
        }

        public void AddFeedBack(FeedBackVM model)
        {
            FeedBack feedBack = new FeedBack()
            {
                Comment = model.Comment,
                Author = model.Author,
                //Date = model.Date
            };
            _db.FeedBacks.Add(feedBack);
            _db.SaveChanges();
        }
    }
}
