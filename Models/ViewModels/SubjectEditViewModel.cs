using Books_Stock_Market.Models.Dtos;

namespace Books_Stock_Market.Models.ViewModels
{
    public class SubjectEditViewModel
    {
        public ICollection<SubjectsDto> Subjects { get; set; }
        public SubjectsDto formData { get; set; }
    }
}
