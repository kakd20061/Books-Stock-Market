using Books_Stock_Market.Areas.Identity.Pages.Account;

namespace Books_Stock_Market.Data.Entities
{
    public class MessageEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Name { get; set; }

        public AnnouncementEntity announcement { get; set; }

        public int AnnouncementForeignKey { get; set; }

        public PageUser pageUser { get; set; }

        public string UserForeignKey { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public MessageEntity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
