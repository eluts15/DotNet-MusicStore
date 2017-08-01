using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class AlbumContext : DbContext
    {
        public AlbumContext (DbContextOptions<AlbumContext> options)
            : base(options)
        {
        }

        public DbSet<Album> Album { get; set; }
    }
}
