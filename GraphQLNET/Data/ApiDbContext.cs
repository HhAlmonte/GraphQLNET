using GraphQLNET.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLNET.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public virtual DbSet<Director>? Directors { get; set; }
        public virtual DbSet<Streamer>? Streamers { get; set; }
        public virtual DbSet<Video>? Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Streamer>()
                .HasMany(d => d.Videos)
                .WithOne(v => v.Streamer)
                .HasForeignKey(v => v.StreamerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Director>()
                .HasMany(d => d.Videos)
                .WithOne(v => v.Director)
                .HasForeignKey(v => v.DirectorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);



            base.OnModelCreating(modelBuilder);
        }
    }
}
