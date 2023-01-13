using Books_Stock_Market.Areas.Identity.Pages.Account;

namespace Books_Stock_Market.Data.Entities
{
    public class RespondMessageEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Name { get; set; }

        public string FromUser { get; set; }

        public string ToUser { get; set; }

        public int AnnouncementID { get; set; }
        
        public bool IsOffer { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public RespondMessageEntity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
