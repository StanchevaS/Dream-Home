using DreamHome.Infrastructure.Data.Models.App;
using DreamHome.Infrastructure.Data.Models.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DreamHome.Data
{
    public class ApplicationDbContext : IdentityDbContext<DreamHomeUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Room> Room { get; set; } = null!;

        public DbSet<RoomType> RoomType { get; set; } = null!;

        public DbSet<AccommodationType> AccommodationType { get; set; } = null!;

        public DbSet<Photo> Photo { get; set; } = null!;

        public DbSet<Reservation> Reservation { get; set; } = null!;

        public DbSet<SpaType> SpaType { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}