using LaMusicCatalog.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaMusicCatalog.Service
{
    public interface IServiceFB
    {
        void AddFeedBack(FeedBackVM model);
    }
}
