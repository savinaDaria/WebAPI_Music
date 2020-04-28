using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavinaMusicLab.Models
{
    public class SavinaMusicContext: DbContext
    {
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<SongGenre> SongGenres { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Band> Bands { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public SavinaMusicContext(DbContextOptions<SavinaMusicContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
