using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().ToTable("Oyunlar").HasMany(g => g.GameGalleries).WithOne(gm => gm.Game).HasForeignKey(s => s.GameId).OnDelete(DeleteBehavior.Cascade);


        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<GameGallery> GameGalleries { get; set; }
    }
}
