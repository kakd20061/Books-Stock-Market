using Books_Stock_Market.Areas.Identity.Pages.Account;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books_Stock_Market.Data.Entities
{
    public class ImageEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ImageName { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }

        public string Subject { get; set; }
        public string Grade { get; set; }
        public string Email { get; set; }

        public PageUser pageUser { get; set; }

        public string UserForeignKey { get; set; }

        public ICollection<MMessageEntity> Messages { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public ImageEntity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
