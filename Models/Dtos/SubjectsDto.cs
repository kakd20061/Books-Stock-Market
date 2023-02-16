using Books_Stock_Market.Data.Entities;
using Books_Stock_Market.Enums;

namespace Books_Stock_Market.Models.Dtos
{
    public class SubjectsDto
    {
        public int Id { get; set; }

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
