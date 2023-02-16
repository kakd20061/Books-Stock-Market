using Books_Stock_Market.Data.Repositories;
using Books_Stock_Market.Models.Dtos;
using Books_Stock_Market.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Books_Stock_Market.Services
{
    public interface IAdministrationViewModelProvider
    {
        AdminManageViewModel PrepareAdminManageViewModel();

        RequestsViewModel PrepareRequestsViewModel();

        SubjectEditViewModel PrepareSubjectsEditViewModel();
        AdminMainViewModel PrepareAdminMainViewModel();

        bool ValidateCreate(AdministrationDto model, ModelStateDictionary modelState);

        bool AdminReturn(string email);

        bool AddAdminGrands(AdministrationDto formData);

        bool RemoveAdminGrands(int Id);
        bool RejectAnnouncement(int Id);

        bool AcceptAnnouncement(int Id);

        bool RejectSubject(int Id);

        bool AcceptSubject(int Id);

        bool RejectOffer(int Id);

        bool AcceptOffer(int Id);

        bool AddSubject(SubjectsDto formData);
    }

    public class AdministrationViewModelProvider : IAdministrationViewModelProvider
    {
        private readonly IAnnouncementsRepository _announcementsRepository;
        private readonly ISubjectRepository _subjectsRepository;
        private readonly IMessagesRepository _messagesRepository;
        private readonly IRespondMessagesRepository _respondMessagesRepository;
        private readonly IAdministrationRepository _administrationRepository;
        private readonly IUserRepository _userRepository;
        private readonly IImageRepository _imageRepository;

        public AdministrationViewModelProvider(IAnnouncementsRepository announcementsRepository, ISubjectRepository subjectsRepository, IMessagesRepository messagesRepository, IRespondMessagesRepository respondMessagesRepository, IAdministrationRepository administrationRepository, IUserRepository userRepository, IImageRepository imageRepository)
        {
            _announcementsRepository = announcementsRepository;
            _subjectsRepository = subjectsRepository;
            _messagesRepository = messagesRepository;
            _respondMessagesRepository = respondMessagesRepository;
            _administrationRepository = administrationRepository;
            _userRepository = userRepository;
            _imageRepository = imageRepository;
        }

        public AdminManageViewModel PrepareAdminManageViewModel()
        {
            var adminList = _administrationRepository.All();
            var procesed = adminList.Select(n=> new AdministrationDto(n)).ToList();

            return new AdminManageViewModel()
            {
                Administration = procesed
            };

        }
        public SubjectEditViewModel PrepareSubjectsEditViewModel()
        {
            var subjects = _subjectsRepository.All(Enums.StatusEnum.Accepted);
            var procesed = subjects.Select(n => new SubjectsDto(n)).ToList();

            return new SubjectEditViewModel()
            {
                Subjects = procesed
            };

        }

        public AdminMainViewModel PrepareAdminMainViewModel()
        {
            var Users = _userRepository.Count();
            var Admins = _administrationRepository.Count();
            var Subjects = _subjectsRepository.Count();
            var Announcements = _announcementsRepository.CountPublished();
            var Requests = _announcementsRepository.CountRequested()+_subjectsRepository.CountRequested()+_imageRepository.CountRequested();
            var InProgress = _announcementsRepository.CountRequested();
            var Rejected = _announcementsRepository.RejectedCount();

            return new AdminMainViewModel()
            {
                UserCount = Users,
                AdminsCount = Admins,
                SubjectsCount = Subjects,
                AnnouncementsCount = Announcements,
                RequestsCount = Requests,
                RejectedCount = Rejected,
                AcceptedCount = Announcements,
                InProgressCount = InProgress,
            };

        }
        public RequestsViewModel PrepareRequestsViewModel()
        {
            var announcements = _announcementsRepository.All(Enums.StatusEnum.InProgress);
            var procesed = announcements.Select(n => new AnnouncementsDto(n)).ToList();
            var subjects = _subjectsRepository.All(Enums.StatusEnum.InProgress);
            var procesed2 = subjects.Select(n => new SubjectsDto(n)).ToList();
            var images = _imageRepository.All(Enums.StatusEnum.InProgress);
            var procesed3 = images.Select(n => new ImagesDto(n)).ToList();
            return new RequestsViewModel()
            {
                Announcements = procesed,
                Subjects = procesed2,
                Images = procesed3
            };
        }

        public bool AdminReturn(string email)
        {
            return _administrationRepository.AdminReturn(email);
        }

        public bool ValidateCreate(AdministrationDto model, ModelStateDictionary modelState)
        {
            return modelState.IsValid;
        }

        public bool AddAdminGrands(AdministrationDto formData)
        {
            var entity = formData.ParseToEntity();
            _administrationRepository.Add(entity);

            return true;
        }

        public bool RemoveAdminGrands(int Id)
        {
            _administrationRepository.Delete(Id);

            return true;
        }
        public bool RejectAnnouncement(int Id)
        {
            _announcementsRepository.Reject(Id);

            return true;
        }

        public bool AcceptAnnouncement(int Id)
        {
            _announcementsRepository.Accept(Id);

            return true;
        }

        public bool RejectSubject(int Id)
        {
            _subjectsRepository.Delete(Id);

            return true;
        }

        public bool AddSubject(SubjectsDto formData)
        {
            var entity = formData.ParseToEntity(true);
            _subjectsRepository.Add(entity);
            return true;
        }

        public bool AcceptSubject(int Id)
        {
            _subjectsRepository.Accept(Id);

            return true;
        }

        public bool RejectOffer(int Id)
        {
            _imageRepository.Reject(Id);

            return true;
        }

        public bool AcceptOffer(int Id)
        {
            _imageRepository.Accept(Id);

            return true;
        }
    }
}
