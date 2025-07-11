using DnDBagOfHolding.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DnDBagOfHolding.Data
{
    public partial class cDbContext : DbContext
    {
        public cDbContext() { }

        public cDbContext(DbContextOptions<cDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\Local;Initial Catalog=DnDContainer;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<cDbCharacter> Characters { get; set; }

        public DbSet<cDbContainer> Containers { get; set; }

        public DbSet<cDbContainerAssignment> ContainerAssignments { get; set; }

        public DbSet<cDbContainerType> ContainerTypes { get; set; }

        public DbSet<cDbItem> Items { get; set; }

        public DbSet<cDbItemAssignment> ItemAssignments { get; set; }

        public DbSet<cDbUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<cDbContainerAssignment>()
            //    .HasOne(x => x.ContainerId)
            //    .With
        }
    }
}
