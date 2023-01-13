using Books_Stock_Market.Models.Dtos;

namespace Books_Stock_Market.Models.ViewModels
{
    public class AnnouncementViewModel
    {
        public ICollection<AnnouncementsDto> Announcements { get; set; }
        public MessagesDto modalData { get; set; }
        public int Id { get; set; }
    }
}
