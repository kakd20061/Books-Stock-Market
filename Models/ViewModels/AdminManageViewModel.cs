using Books_Stock_Market.Models.Dtos;

namespace Books_Stock_Market.Models.ViewModels
{
    public class AdminManageViewModel
    {
        public ICollection<AdministrationDto> Administration { get; set; }

        public AdministrationDto formData { get; set; }
    }
}
