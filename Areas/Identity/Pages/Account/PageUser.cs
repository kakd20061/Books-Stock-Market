using Books_Stock_Market.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace Books_Stock_Market.Areas.Identity.Pages.Account
{
    public class PageUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }

        public ICollection<AnnouncementEntity> Announcements { get; set; }
        public ICollection<MessageEntity> Messages { get; set; }
        public ICollection<MMessageEntity> MMessages { get; set; }
        public ICollection<ImageEntity> Images { get; set; }
    }
}
