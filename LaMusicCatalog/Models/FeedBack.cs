﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaMusicCatalog.Models
{
    public class FeedBack
    {
        public int Id { get; set; }
        //public DateTime Date { get; set; }
        public string Comment { get; set; }
        public string Author { get; set; }
    }
}