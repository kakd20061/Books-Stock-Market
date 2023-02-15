using Books_Stock_Market.Data.Repositories;
using Books_Stock_Market.Models.Dtos;
using Books_Stock_Market.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Books_Stock_Market.Services
{
    public interface IAnnouncementsViewModelProvider
    {
        AnnouncementViewModel PrepareAnnouncementsViewModel();
        AnnouncementManageViewModel PrepareAnnouncementsManageViewModel(string user);
        MessagesViewModel PrepareMessagesViewModel(string user);

        MarketplaceViewModel PrepareMarketplaceViewModel();
        MarketplaceViewModel PrepareMarketplaceWithSearchViewModel(string content);

        bool ValidateCreate(AnnouncementsDto model, ModelStateDictionary modelState);

        bool Add(AnnouncementsDto model, string user, string number, string name, string email, bool isChecked);

        bool AddMessage(MessagesDto model, string user, string name, int announcement, string title);
        bool AddMMessage(MMessagesDto model, string user, string name, int offers, string title);
        bool AddSubject(SubjectsDto model);
        bool Remove(int Id);
        bool Delete(int Id);
        bool DeleteMMessage(int Id);
        bool DeleteRespond(int Id);
        bool Respond(RespondMessagesDto model, string FromUser, string ToUser, string name, int announcement, string title, bool isOffer = false);

        bool AddImage(ImagesDto model, string UserId, string Email);

        bool OfferRemove(int Id);

        OfferViewModel PrepareOfferViewModel(string id);
    }

    public class AnnouncementsViewModelProvider : IAnnouncementsViewModelProvider
    {
        private readonly IAnnouncementsRepository _announcementsRepository;
        private readonly ISubjectRepository _subjectsRepository;
        private readonly IMessagesRepository _messagesRepository;
        private readonly IMMessagesRepository _mmessagesRepository;
        private readonly IRespondMessagesRepository _respondMessagesRepository;
        private readonly IImageRepository _imageRepository;

        public AnnouncementsViewModelProvider(IAnnouncementsRepository announcementsRepository, ISubjectRepository subjectsRepository, IMessagesRepository messagesRepository, IRespondMessagesRepository respondMessagesRepository, IImageRepository imageRepository, IMMessagesRepository mmessagesRepository)
        {
            _announcementsRepository = announcementsRepository;
            _subjectsRepository = subjectsRepository;
            _messagesRepository = messagesRepository;
            _respondMessagesRepository = respondMessagesRepository;
            _imageRepository = imageRepository;
            _mmessagesRepository = mmessagesRepository;
        }

        public AnnouncementManageViewModel PrepareAnnouncementsManageViewModel(string user)
        {
            var announcements = _announcementsRepository.All(user);
            var procesed = announcements.Select(n => new AnnouncementsDto(n)).ToList();
            var subjects = _subjectsRepository.All();
            var procesed2 = subjects.Select(n => new SubjectsDto(n)).ToList();

            return new AnnouncementManageViewModel()
            {
                Announcements = procesed,
                Subjects = procesed2
            };
        }

        public AnnouncementViewModel PrepareAnnouncementsViewModel()
        {
            var announcements = _announcementsRepository.All();
            var procesed = announcements.Select(n => new AnnouncementsDto(n)).ToList();

            return new AnnouncementViewModel()
            {
                Announcements = procesed
            };
        }

        public MessagesViewModel PrepareMessagesViewModel(string user)
        {
            var messages = _messagesRepository.All(user);
            var mmessages = _mmessagesRepository.All(user);
            var respondMessages = _respondMessagesRepository.All(user);
            var procesed = messages.Select(n => new MessagesDto(n)).ToList();
            var procesed2 = respondMessages.Select(n => new RespondMessagesDto(n)).ToList();
            var procesed3 = mmessages.Select(n=> new MMessagesDto(n)).ToList();

            return new MessagesViewModel()
            {
                Messages = procesed,
                MMessages = procesed3,
                RespondMessages = procesed2
            };

        }

        public MarketplaceViewModel PrepareMarketplaceViewModel()
        {
            var subjects = _subjectsRepository.All();
            var procesed = subjects.Select(n => new SubjectsDto(n)).ToList();
            var offers = _imageRepository.All();
            var procesed2 = offers.Select(n => new ImagesDto(n)).ToList();

            return new MarketplaceViewModel()
            {
                Subjects = procesed,
                Images = procesed2
            };
        }

        public MarketplaceViewModel PrepareMarketplaceWithSearchViewModel(string content)
        {
            var subjects = _subjectsRepository.All();
            var procesed = subjects.Select(n => new SubjectsDto(n)).ToList();
            var offers = _imageRepository.Search(content);
            var procesed2 = offers.Select(n => new ImagesDto(n)).ToList();

            return new MarketplaceViewModel()
            {
                Subjects = procesed,
                Images = procesed2
            };
        }
        public OfferViewModel PrepareOfferViewModel(string id)
        {
            var subjects = _subjectsRepository.All();
            var procesed = subjects.Select(n => new SubjectsDto(n)).ToList();
            var offers = _imageRepository.All(id); 
            var procesed2 = offers.Select(n => new ImagesDto(n)).ToList();


            return new OfferViewModel()
            {
                Subjects = procesed,
                Offers = procesed2
            };
        }


        //update message prepare

        public bool ValidateCreate(AnnouncementsDto model, ModelStateDictionary modelState)
        {
            if (string.IsNullOrEmpty(model.Title))
            {
                modelState.AddModelError(nameof(model.Title), "Title can't be empty!");
            }
            if (string.IsNullOrEmpty(model.Name))
            {
                modelState.AddModelError(nameof(model.Name), "Name can't be empty!");
            }
            if (string.IsNullOrEmpty(model.PhoneNumber.ToString()))
            {
                modelState.AddModelError(nameof(model.PhoneNumber), "Phone can't be empty!");
            }
            if (string.IsNullOrEmpty(model.PhotoUrl))
            {
                modelState.AddModelError(nameof(model.PhotoUrl), "Url can't be empty!");
            }
            return modelState.IsValid;
        }
        public bool Add(AnnouncementsDto model, string user, string number, string name, string email, bool isChecked)
        {
            var entity = model.ParseToEntity(user, number, name, email, isChecked);
            _announcementsRepository.Add(entity);
            return true;
        }

        public bool AddMessage(MessagesDto model, string user, string name, int announcement, string title)
        {
            var entity = model.ParseToEntity(user, name, announcement, title);
            _messagesRepository.Add(entity);
            return true;
        }

        public bool AddMMessage(MMessagesDto model, string user, string name, int offers, string title)
        {
            var entity = model.ParseToEntity(user, name, offers, title);
            _mmessagesRepository.Add(entity);
            return true;
        }

        public bool Respond(RespondMessagesDto model, string FromUser, string ToUser, string name, int announcement, string title, bool isOffer = false)
        {
            var entity = model.ParseToEntity(FromUser, ToUser, announcement, name, title, isOffer);

            _respondMessagesRepository.Add(entity);
            return true;
        }

        public bool Remove(int Id)
        {
            _announcementsRepository.Delete(Id);
            return true;
        }

        public bool OfferRemove(int Id)
        {
            _imageRepository.Delete(Id);
            return true;
        }

        public bool Delete(int Id)
        {
            _messagesRepository.Delete(Id);
            return true;
        }

        public bool DeleteMMessage(int Id)
        {
            _mmessagesRepository.Delete(Id);
            return true;
        }

        public bool DeleteRespond(int Id)
        {
            _respondMessagesRepository.Delete(Id);
            return true;
        }

        public bool AddSubject(SubjectsDto model)
        {
            var entity = model.ParseToEntity();

            _subjectsRepository.Add(entity);
            return true;
        }

        public bool AddImage(ImagesDto model, string UserId, string Email)
        {
            var entity = model.ParseToEntity(Email,UserId);

            _imageRepository.Add(entity);
            return true;
        }
    }
}
