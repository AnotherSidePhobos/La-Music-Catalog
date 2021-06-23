using LaMusicCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaMusicCatalog
{
    public interface IMusicItemService
    {
        public void Add(MusicItem musicItem);
        public IEnumerable<MusicItem> GetAll();
        public MusicItem GetById(int id);
        public string GetTitle(int id);
        public string GetAuthor(int id);
        public string GetDate(int id);
        public string GetType(int id);
        public IEnumerable<MusicItem> GetOnlyNotes();
        public IEnumerable<MusicItem> GetOnlyChords();
    }
}