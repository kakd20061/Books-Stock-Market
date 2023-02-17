using Books_Stock_Market.Data.Entities;
using Books_Stock_Market.Enums;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Books_Stock_Market.Models.Dtos
{
    public class AnnouncementsDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Photo Url")]
        public string PhotoUrl { get; set; }

        public string PhoneNumber { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string GradeNumber { get; set; }

        public string Subject { get; set; }

        public bool PhoneAgree { get; set; }
        public StatusEnum Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public AnnouncementsDto()
        {

        }

        public AnnouncementsDto(AnnouncementEntity entity) : base()
        {
            Id = entity.Id;
            Title = entity.Title;
            PhotoUrl = entity.PhotoUrl;
            PhoneNumber = entity.PhoneNumber;
            Name = entity.Name;
            CreatedAt = entity.CreatedAt;
            GradeNumber = entity.GradeNumber;
            Subject = entity.Subject;
            PhoneAgree = entity.PhoneAgree;
            Email = entity.Email;
            Status = entity.Status;
        }

        public AnnouncementEntity ParseToEntity(string UserId,string PhoneNumber, string Name, string Email, bool isChecked = false, bool isRejeceted = false)
        {
            return new AnnouncementEntity()
            {
                Id = this.Id,
                Title = this.Title,
                PhotoUrl = this.PhotoUrl,
                PhoneNumber = PhoneNumber,
                Name = Name,
                CreatedAt = this.CreatedAt,
                UserForeignKey = UserId,
                GradeNumber = this.GradeNumber,
                Subject = this.Subject,
                PhoneAgree = this.PhoneAgree,
                Email = Email,
                Status = StatusEnum.InProgress
            };
        }
    }
}
