using Books_Stock_Market.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Books_Stock_Market.Data.Seeds
{
    public class SubjectsSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<SubjectEntity>()
                .HasData(
                    new SubjectEntity()
                    {
                        Id = 1,
                        SubjectName = "J. Angielski"
                    }
                );
            builder.Entity<SubjectEntity>()
                .HasData(
                    new SubjectEntity()
                    {
                        Id = 2,
                        SubjectName = "J. Polski"
                    }
                );
            builder.Entity<SubjectEntity>()
                .HasData(
                    new SubjectEntity()
                    {
                        Id = 3,
                        SubjectName = "J. Niemiecki"
                    }
                );
            builder.Entity<SubjectEntity>()
                .HasData(
                    new SubjectEntity()
                    {
                        Id = 4,
                        SubjectName = "Matematyka"
                    }
                );
        }
    }
}
