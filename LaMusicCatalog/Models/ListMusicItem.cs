using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaMusicCatalog.Models
{
    public class ListMusicItem
    {
        public IEnumerable<MusicItem> MusicItems { get; set; }
    }
}
