using Books_Stock_Market.Models.Dtos;

namespace Books_Stock_Market.Models.ViewModels
{
    public class RequestsViewModel
    {
        public ICollection<AnnouncementsDto> Announcements { get; set; }
        public ICollection<SubjectsDto> Subjects { get; set; }
        public ICollection<ImagesDto> Images { get; set; }
    }
}
