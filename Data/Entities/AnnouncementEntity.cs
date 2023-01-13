using Books_Stock_Market.Areas.Identity.Pages.Account;

namespace Books_Stock_Market.Data.Entities
{
    public class AnnouncementEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string PhotoUrl { get; set; }

        public string PhoneNumber { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string GradeNumber { get; set; }

        public string Subject { get; set; }

        public string UserForeignKey { get; set; }

        public PageUser pageUser { get; set; }

        public ICollection<MessageEntity> Messages { get; set; }

        public bool PhoneAgree { get; set; }

        public bool IsChecked { get; set; }

        public bool IsRejected { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public AnnouncementEntity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            IsChecked = false;
            IsRejected = false;
        }
    }
}
