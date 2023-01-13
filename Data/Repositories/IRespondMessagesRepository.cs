using Books_Stock_Market.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Books_Stock_Market.Data.Repositories
{
        public interface IRespondMessagesRepository
        {
            ICollection<RespondMessageEntity> All();
            ICollection<RespondMessageEntity> All(string user);

            int Count();

            RespondMessageEntity One(int id);

            bool Add(RespondMessageEntity entity);

            bool Delete(int id);

            RespondMessageEntity Edit(RespondMessageEntity entity);
        }

        public class RespondMessagesRepository : IRespondMessagesRepository
        {
            private readonly ApplicationDbContext _dbContext;

            public RespondMessagesRepository(ApplicationDbContext dbContext)
            {
                _dbContext = dbContext;
            }


            public bool Add(RespondMessageEntity entity)
            {
                entity.CreatedAt = DateTime.UtcNow;
                entity.UpdatedAt = DateTime.UtcNow;
                _dbContext.RespondMessages.Add(entity);
                return _dbContext.SaveChanges() > 0;
            }

            public ICollection<RespondMessageEntity> All()
            {
                return _dbContext.RespondMessages.Select(n => n).ToList();
            }

            public ICollection<RespondMessageEntity> All(string user)
            {
                return _dbContext.RespondMessages.Select(n => n).Where(n => n.ToUser == user).ToList();
            }
            public int Count()
            {
                return _dbContext.RespondMessages.Count();
            }

            public bool Delete(int id)
            {
                var entity = One(id);
                if (entity.Title != null && entity.Title != "")
                    _dbContext.RespondMessages.Remove(entity);

                return _dbContext.SaveChanges() > 0;
            }

            public RespondMessageEntity Edit(RespondMessageEntity entity)
            {
                var dbEntity = One(entity.Id);

                dbEntity.Title = entity.Title;

                dbEntity.Content = entity.Content;

                entity.UpdatedAt = DateTime.UtcNow;

                _dbContext.RespondMessages.Update(dbEntity);

                _dbContext.SaveChanges();

                return dbEntity;
            }

            public RespondMessageEntity One(int id)
            {
                return _dbContext.RespondMessages.FirstOrDefault(n => n.Id == id) ?? new RespondMessageEntity();
            }

    }
}
