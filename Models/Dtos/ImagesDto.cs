using Books_Stock_Market.Data.Entities;
using Books_Stock_Market.Enums;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Books_Stock_Market.Models.Dtos
{
    public class ImagesDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        public string ImageName { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        [Display(Name = "Price")]
        public int Price { get; set; }
        public string Email { get; set; }
        [Required]
        [Display(Name = "Image file")]
        public IFormFile ImageFile { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
        [DataType(DataType.Text)]
        [Display(Name = "Description")]
        public string Description { get; set; }
        public string Subject { get; set; }
        public string Grade { get; set; }

        public DateTime CreatedAt { get; set; }
        public StatusEnum Status { get; set; }

        public ImagesDto()
        {

        }

        public ImagesDto(ImageEntity entity) : base()
        {
            Id = entity.Id;
            Title = entity.Title;
            ImageName = entity.ImageName;
            CreatedAt = entity.CreatedAt;
            Price = entity.Price;
            ImageFile = entity.ImageFile;
            Description = entity.Description;
            Subject = entity.Subject;
            Email = entity.Email;
            Grade = entity.Grade;
            Status = entity.Status;
        }

        public ImageEntity ParseToEntity(string Email, string UserId)
        {
            return new ImageEntity()
            {
                Id = this.Id,
                Title = this.Title,
                ImageName = this.ImageName,
                CreatedAt = this.CreatedAt,
                Price = this.Price,
                Description = this.Description,
                ImageFile = this.ImageFile,
                Subject = this.Subject,
                Email = Email,
                UserForeignKey = UserId,
                Grade = this.Grade,
                Status = StatusEnum.InProgress
            };
        }
    }
}
