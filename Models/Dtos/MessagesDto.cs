using Books_Stock_Market.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Books_Stock_Market.Models.Dtos
{
    public class MessagesDto
    {
        public int Id { get; set; }

        public string Title { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name = "Content")]
        public string Content { get; set; }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public MessagesDto()
        {

        }

        public MessagesDto(MessageEntity entity) : base()
        {
            Id = entity.Id;
            Title = entity.Title;
            Content = entity.Content;
            Name = entity.Name;
            CreatedAt = entity.CreatedAt;
        }

        public MessageEntity ParseToEntity(string UserId, string Name, int AnnouncementId, string Title)
        {
            return new MessageEntity()
            {
                Id = this.Id,
                Title = Title,
                Content = this.Content,
                Name = Name,
                UserForeignKey = UserId,
                AnnouncementForeignKey = AnnouncementId,
                CreatedAt = this.CreatedAt,
            };
        }
    }
}
