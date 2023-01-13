using Books_Stock_Market.Data.Entities;

namespace Books_Stock_Market.Models.Dtos
{
    public class MMessagesDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public MMessagesDto()
        {

        }

        public MMessagesDto(MMessageEntity entity) : base()
        {
            Id = entity.Id;
            Title = entity.Title;
            Content = entity.Content;
            Name = entity.Name;
            CreatedAt = entity.CreatedAt;
        }

        public MMessageEntity ParseToEntity(string UserId, string Name, int OfferId, string Title)
        {
            return new MMessageEntity()
            {
                Id = this.Id,
                Title = Title,
                Content = this.Content,
                Name = Name,
                UserForeignKey = UserId,
                OffersForeignKey = OfferId,
                CreatedAt = this.CreatedAt,
            };
        }
    }
}
