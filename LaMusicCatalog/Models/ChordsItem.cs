using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaMusicCatalog.Models
{
    public class ChordsItem : MusicItem
    {
        // in that case chords are chords for the guitar only
        public string Tonality { get; set; }
    }
}
