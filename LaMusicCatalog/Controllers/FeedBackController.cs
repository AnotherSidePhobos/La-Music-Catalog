using LaMusicCatalog.Models.ViewModels;
using LaMusicCatalog.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaMusicCatalog.Controllers
{
    [Route("FeedBack")]
    [ApiController]
    public class FeedBackController : Controller
    {
        private readonly IServiceFB _service;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public FeedBackController(IServiceFB service, IHttpContextAccessor httpContextAccessor)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
        [HttpPost]
        [Route("SaveFeedBack")]
        public void SaveFeedBack(FeedBackVM data)
        {

            _service.AddFeedBack(data);

        }
    }
}
