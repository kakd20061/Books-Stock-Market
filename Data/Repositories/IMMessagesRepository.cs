using Books_Stock_Market.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Books_Stock_Market.Data.Repositories
{
    public interface IMMessagesRepository
    {
        ICollection<MMessageEntity> All();

        ICollection<MMessageEntity> All(string Id);

        int Count();

        MMessageEntity One(int id);

        bool Add(MMessageEntity entity);

        bool Delete(int id);
    }

    public class MMessagesRepository : IMMessagesRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public MMessagesRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool Add(MMessageEntity entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            _dbContext.MMessage.Add(entity);
            return _dbContext.SaveChanges() > 0;
            //naprawić
        }

        public ICollection<MMessageEntity> All()
        {
            return _dbContext.MMessage.Select(n => n).ToList();
        }

        public ICollection<MMessageEntity> All(string Id)
        {
            //zmiana
            return _dbContext.MMessage.Include(n=>n.offers).Select(n => n).Where(n => n.offers.UserForeignKey == Id).ToList();
        }

        public int Count()
        {
            return _dbContext.MMessage.Count();
        }

        public bool Delete(int id)
        {
            var entity = One(id);
            if (entity.Title != null && entity.Title != "")
                _dbContext.MMessage.Remove(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public MMessageEntity One(int id)
        {
            return _dbContext.MMessage.FirstOrDefault(n => n.Id == id) ?? new MMessageEntity();
        }

    }
}
