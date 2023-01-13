using Books_Stock_Market.Data.Entities;
using Books_Stock_Market.Models.Dtos;

namespace Books_Stock_Market.Models.ViewModels
{
    public class OfferViewModel
    {
        public ImagesDto Image;

        public ICollection<SubjectsDto> Subjects;
    }
}
