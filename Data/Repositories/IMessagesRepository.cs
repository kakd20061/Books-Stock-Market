using Books_Stock_Market.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Books_Stock_Market.Data.Repositories
{
    public interface IMessagesRepository
    {
        ICollection<MessageEntity> All();

        ICollection<MessageEntity> All(string Id);

        int Count();

        MessageEntity One(int id);

        bool Add(MessageEntity entity);

        bool Delete(int id);

        MessageEntity Edit(MessageEntity entity);
    }

    public class MessagesRepository : IMessagesRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public MessagesRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool Add(MessageEntity entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            _dbContext.Messages.Add(entity);
            return _dbContext.SaveChanges() > 0;
            //naprawić
        }

        public ICollection<MessageEntity> All()
        {
            return _dbContext.Messages.Select(n => n).ToList();
        }

        public ICollection<MessageEntity> All(string Id)
        {
            //zmiana
            return _dbContext.Messages.Include(n=>n.announcement).Select(n => n).Where(n => n.announcement.UserForeignKey == Id).ToList();
        }

        public int Count()
        {
            return _dbContext.Messages.Count();
        }

        public bool Delete(int id)
        {
            var entity = One(id);
            if (entity.Title != null && entity.Title != "")
                _dbContext.Messages.Remove(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public MessageEntity Edit(MessageEntity entity)
        {
            var dbEntity = One(entity.Id);

            dbEntity.Title = entity.Title;

            dbEntity.Content = entity.Content;

            entity.UpdatedAt = DateTime.UtcNow;

            _dbContext.Messages.Update(dbEntity);

            _dbContext.SaveChanges();

            return dbEntity;
        }

        public MessageEntity One(int id)
        {
            return _dbContext.Messages.FirstOrDefault(n => n.Id == id) ?? new MessageEntity();
        }

    }
}
