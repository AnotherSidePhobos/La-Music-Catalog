using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaMusicCatalog.Models.ViewModels
{
    public class FeedBackVM
    {
        public int? Id { get; set; }
        //public DateTime Date { get; set; }
        public string Comment { get; set; }
        public string Author { get; set; }
    }
}
