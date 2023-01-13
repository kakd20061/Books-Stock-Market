using Books_Stock_Market.Models.Dtos;

namespace Books_Stock_Market.Models.ViewModels
{
    public class AnnouncementManageViewModel
    {
        public ICollection<AnnouncementsDto> Announcements { get; set; }
        public ICollection<SubjectsDto> Subjects { get; set; }
        public SubjectsDto subjectData { get; set; }
        public AnnouncementsDto formData { get; set; }
    }
}
