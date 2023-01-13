using Books_Stock_Market.Data.Entities;

namespace Books_Stock_Market.Models.Dtos
{
    public class AdministrationDto
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public DateTime CreatedAt { get; set; }

        public AdministrationDto()
        {

        }

        public AdministrationDto(AdministrationEntity entity) : base()
        {
            Id = entity.Id;
            Email = entity.Email;
            CreatedAt = entity.CreatedAt;
        }

        public AdministrationEntity ParseToEntity()
        {
            return new AdministrationEntity()
            {
                Id = this.Id,
                Email = Email,
                CreatedAt = this.CreatedAt
            };
        }
    }
}
