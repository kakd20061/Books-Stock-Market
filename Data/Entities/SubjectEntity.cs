using Books_Stock_Market.Enums;

namespace Books_Stock_Market.Data.Entities
{
    public class SubjectEntity
    {
        public int Id { get; set; }

        public string SubjectName { get; set; }

        public StatusEnum Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public SubjectEntity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
