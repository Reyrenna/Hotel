using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Hotel.Models;

namespace Hotel.Data
{
    public class HotelDbContext : IdentityDbContext<Client, Role, string,
        IdentityUserClaim<string>, RoleUser, IdentityUserLogin<string>,
        IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options)
            : base(options)
        {
        }
        public DbSet<Room> Room { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleUser> RoleUser { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<RoleUser>()
                .HasOne(p => p.User)
                .WithMany(p => p.RoleUser)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<RoleUser>()
                .HasOne(p => p.Role)
                .WithMany(p => p.RoleUser)
                .HasForeignKey(p => p.RoleId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Reservation>()
                .HasOne(p => p.Client)
                .WithMany(p => p.Room)
                .HasForeignKey(p => p.IdClient)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Reservation>()
                .HasOne(p => p.Room)
                .WithMany(p => p.Client)
                .HasForeignKey(p => p.IdRoom)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Reservation>()
                .Property(p => p.CheckIn)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired(true);
        }
    }
}
