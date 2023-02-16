using Books_Stock_Market.Data.Entities;
using Books_Stock_Market.Enums;
using Microsoft.EntityFrameworkCore;

namespace Books_Stock_Market.Data.Repositories
{
    public interface IAnnouncementsRepository
    {
        ICollection<AnnouncementEntity> All(string Id);
        ICollection<AnnouncementEntity> All();
        ICollection<AnnouncementEntity> All(StatusEnum status);

        int Count();

        int CountPublished();
        int CountRequested();
        int RejectedCount();

        AnnouncementEntity One(int id);

        bool Add(AnnouncementEntity entity);

        bool Delete(int id);

        bool Accept(int id);
        bool Reject(int id);

        AnnouncementEntity Edit(AnnouncementEntity entity);
    }

    public class AnnouncementsRepository : IAnnouncementsRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public AnnouncementsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool Add(AnnouncementEntity entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            _dbContext.Announcements.Add(entity);
            return _dbContext.SaveChanges() > 0;
            //naprawić
        }

        public ICollection<AnnouncementEntity> All()
        {
            return _dbContext.Announcements.Select(n => n).ToList();
        }

        public ICollection<AnnouncementEntity> All(string Id)
        {
            return _dbContext.Announcements.Include(n=>n.pageUser).Select(n => n).Where(n=>n.UserForeignKey == Id).ToList();
        }

        public ICollection<AnnouncementEntity> All(StatusEnum status)
        {
            return _dbContext.Announcements.Select(n => n).Where(n=>n.Status == status).ToList();
        }

        public int Count()
        {
            return _dbContext.Announcements.Count();
        }

        public int CountPublished()
        {
            return _dbContext.Announcements.Count(n => n.Status == Enums.StatusEnum.Accepted);
        }

        public int CountRequested()
        {
            return _dbContext.Announcements.Count(n => n.Status == Enums.StatusEnum.InProgress);
        }

        public int RejectedCount()
        {
            return _dbContext.Announcements.Count(n => n.Status == Enums.StatusEnum.Rejected);
        }

        public bool Delete(int id)
        {
            var entity = One(id);
            if (entity.Title != null && entity.Title != "")
                _dbContext.Announcements.Remove(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public bool Accept(int id)
        {
            var entity = One(id);
            entity.Status = Enums.StatusEnum.Accepted;
            _dbContext.Announcements.Update(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public bool Reject(int id)
        {
            var entity = One(id);
            entity.Status = Enums.StatusEnum.Rejected;
            _dbContext.Announcements.Update(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public AnnouncementEntity Edit(AnnouncementEntity entity)
        {
            var dbEntity = One(entity.Id);

            dbEntity.Title = entity.Title;

            dbEntity.PhotoUrl = entity.PhotoUrl;

            dbEntity.PhoneNumber = entity.PhoneNumber;

            dbEntity.Name = entity.Name;

            dbEntity.PhoneAgree = entity.PhoneAgree;

            entity.UpdatedAt = DateTime.UtcNow;

            _dbContext.Announcements.Update(dbEntity);

            _dbContext.SaveChanges();

            return dbEntity;
        }

        public AnnouncementEntity One(int id)
        {
            return _dbContext.Announcements.FirstOrDefault(n => n.Id == id) ?? new AnnouncementEntity();
        }

    }
}
