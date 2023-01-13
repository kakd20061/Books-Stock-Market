using Books_Stock_Market.Models.Dtos;

namespace Books_Stock_Market.Models.ViewModels
{
    public class MessagesViewModel
    {
        public ICollection<MessagesDto> Messages { get; set; }
        public ICollection<MMessagesDto> MMessages { get; set; }

        public ICollection<RespondMessagesDto> RespondMessages { get; set; }

        public RespondMessagesDto respondData { get; set; }

        public int messageAnnId { get; set; }

        public RespondMessagesDto respondToRespondData { get; set; }

        public int messageId { get; set; }

        public bool isOffer { get; set; }
    }
}
