using Books_Stock_Market.Areas.Identity.Pages.Account;
using Books_Stock_Market.Data.Entities;
using Books_Stock_Market.Data.Seeds;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static NuGet.Packaging.PackagingConstants;

namespace Books_Stock_Market.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<PageUser> Users { get; set; }
        public DbSet<SubjectEntity> Subjects { get; set; }
        public DbSet<AnnouncementEntity> Announcements { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }
        public DbSet <AdministrationEntity> Administration  { get; set; }

        public DbSet<RespondMessageEntity> RespondMessages { get; set; }
        public DbSet<ImageEntity> Images { get; set; }
        public DbSet<MMessageEntity> MMessage { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PageUser>()
                .HasMany(n => n.Announcements)
                .WithOne(n => n.pageUser)
                .HasForeignKey(n => n.UserForeignKey);

            builder.Entity<PageUser>()
                .HasMany(n => n.Images)
                .WithOne(n => n.pageUser)
                .HasForeignKey(n => n.UserForeignKey);

            builder.Entity<PageUser>()
                .HasMany(n => n.Messages)
                .WithOne(n => n.pageUser)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(n => n.UserForeignKey);

            builder.Entity<PageUser>()
                .HasMany(n => n.MMessages)
                .WithOne(n => n.pageUser)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(n => n.UserForeignKey);

            builder.Entity<AnnouncementEntity>()
                .HasMany(n => n.Messages)
                .WithOne(n => n.announcement)
                .HasForeignKey(n => n.AnnouncementForeignKey);

            builder.Entity<ImageEntity>()
                .HasMany(n => n.Messages)
                .WithOne(n => n.offers)
                .HasForeignKey(n => n.OffersForeignKey);

            SubjectsSeeder.Seed(builder);
            FirstAdminSeeder.Seed(builder);
        }
    }
}