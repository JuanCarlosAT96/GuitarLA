using GuitarLA.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace GuitarLA.Server.Context
{
    public class GuitarLAContext : DbContext
    {
        public GuitarLAContext(DbContextOptions<GuitarLAContext> options) : base(options)
        {

        }
        //DdSets
        public DbSet<User> Users { get; set; }
        public DbSet<Guitar> Guitars { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guitar>()
                .HasOne(g => g.User) //One guitar has one User
                .WithMany(u => u.Guitars) // One user has to much Guitars
                .HasForeignKey(g => g.UserId); //The foreign key is UserId
        }
    }
}
