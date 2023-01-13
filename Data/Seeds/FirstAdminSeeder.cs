using Books_Stock_Market.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Books_Stock_Market.Data.Seeds
{
    public class FirstAdminSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<AdministrationEntity>()
                .HasData(
                    new AdministrationEntity()
                    {
                        Id = 1,
                        Email = "gizard.biznes123@vp.pl"
                    }
                );
        }
    }
}
