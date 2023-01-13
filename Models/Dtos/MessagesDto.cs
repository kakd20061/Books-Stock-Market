using Books_Stock_Market.Data.Entities;

namespace Books_Stock_Market.Models.Dtos
{
    public class MessagesDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

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
