using LaMusicCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaMusicCatalog
{
    public class MusicItemService : IMusicItemService
    {
        private readonly ApplicationDbContext _db;
        public MusicItemService(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Add(MusicItem musicItem)
        {
            _db.Add(musicItem);
            _db.SaveChanges();
        }

        public IEnumerable<MusicItem> GetAll()
        {

            return _db.MusicItems;
        }
        public MusicItem GetById(int id)
        {
            return GetAll()
                .FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<MusicItem> GetOnlyNotes()
        {
            return _db.MusicItems.OfType<NoteItem>();
        }
        public IEnumerable<MusicItem> GetOnlyChords()
        {
            return _db.MusicItems.OfType<ChordsItem>();
        }
        public string GetAuthor(int id)
        {
            return GetById(id).Author;
        }

        public string GetTitle(int id)
        {
            return GetById(id).Title;
        }

        public string GetType(int id)
        {
            var notes = _db.MusicItems.OfType<NoteItem>()
                .Where(i => i.Id == id);
            return notes.Any() ? "Notes" : "Chords";
        }

        public string GetDate(int id)
        {
            return GetById(id).Date.ToShortDateString();
        }
    }
}
