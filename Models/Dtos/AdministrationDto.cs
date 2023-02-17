using Books_Stock_Market.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Books_Stock_Market.Models.Dtos
{
    public class AdministrationDto
    {
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
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
