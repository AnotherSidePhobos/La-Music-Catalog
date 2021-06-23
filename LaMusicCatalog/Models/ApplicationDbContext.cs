using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaMusicCatalog.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        
        public DbSet<MusicItem> MusicItems { get; set; }
        public DbSet<ChordsItem> ChordsItems { get; set; }
        public DbSet<NoteItem> NoteItems { get; set; }
        public DbSet<UsersItems> UsersItems { get; set; }
    }
}