using Books_Stock_Market.Models.Dtos;

namespace Books_Stock_Market.Models.ViewModels
{
    public class MarketplaceViewModel
    {
        public ICollection<SubjectsDto> Subjects { get; set; }
        public ICollection<ImagesDto> Images { get; set; }

        public MMessagesDto modalData { get; set; }
        public int Id { get; set; }
    }
}
