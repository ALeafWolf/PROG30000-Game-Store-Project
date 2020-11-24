using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Team_WASD___Game_Store_Stock_Management_System.Models
{
    public class GameStoreDBContext : DbContext
    {

        public GameStoreDBContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Developer> Developers { get; set; }

        public DbSet<Platform> Platform { get; set; }


        public DbSet<Image> Images { get; set; }


    }
}
