using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaMusicCatalog.Models
{
    public class UsersItems
    {
        public int Id { get; set; }
        public string ApplicationUserName { get; set; }
        public int MusicItemId { get; set; }
    }
}