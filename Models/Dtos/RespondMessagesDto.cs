using Books_Stock_Market.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Books_Stock_Market.Models.Dtos
{
    public class RespondMessagesDto
    {
        public int Id { get; set; }

        public string Title { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name = "Content")]
        public string Content { get; set; }

        public string Name { get; set; }

        public bool IsOffer { get; set; }

        public DateTime CreatedAt { get; set; }

        public RespondMessagesDto()
        {

        }

        public RespondMessagesDto(RespondMessageEntity entity) : base()
        {
            Id = entity.Id;
            Title = entity.Title;
            Content = entity.Content;
            Name = entity.Name;
            CreatedAt = entity.CreatedAt;
            IsOffer = entity.IsOffer;
        }

        public RespondMessageEntity ParseToEntity(string FromUser, string ToUser, int AnnouncementID, string Name, string Title, bool isOffer)
        {
            return new RespondMessageEntity()
            {
                Id = this.Id,
                Title = Title,
                Content = this.Content,
                Name = Name,
                FromUser = FromUser,
                ToUser = ToUser,
                AnnouncementID = AnnouncementID,
                CreatedAt = this.CreatedAt,
                IsOffer = isOffer
            };
        }
    }
}
