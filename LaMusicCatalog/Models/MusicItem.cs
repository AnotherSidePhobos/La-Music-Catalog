using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaMusicCatalog.Models
{
    public class MusicItem
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string ImageUrl { get; set; }
        public string FileUrl { get; set; }
        public List<ApplicationUser> ApplicationUsers { get; set; } = new List<ApplicationUser>();

    }
}