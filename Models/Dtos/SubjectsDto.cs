using Books_Stock_Market.Data.Entities;
using Books_Stock_Market.Enums;
using System.ComponentModel.DataAnnotations;

namespace Books_Stock_Market.Models.Dtos
{
    public class SubjectsDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Subject Name")]
        public string SubjectName { get; set; }

        public StatusEnum Status { get; set; }

        public SubjectsDto()
        {

        }

        public SubjectsDto(SubjectEntity entity) : base()
        {
            Id = entity.Id;
            SubjectName = entity.SubjectName;
            Status = entity.Status;
        }

        public SubjectEntity ParseToEntity(bool isChecked = false)
        {
            return new SubjectEntity()
            {
                Id = this.Id,
                SubjectName = this.SubjectName,
                Status = StatusEnum.InProgress
            };
        }
    }
}
