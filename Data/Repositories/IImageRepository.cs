using Books_Stock_Market.Data.Entities;
using Books_Stock_Market.Enums;
using Microsoft.EntityFrameworkCore;

namespace Books_Stock_Market.Data.Repositories
{
    public interface IImageRepository
    {
        bool Add(ImageEntity entity);
        ICollection<ImageEntity> All();
        ICollection<ImageEntity> All(StatusEnum status);
        ICollection<ImageEntity> All(string id);
        ICollection<ImageEntity> Search(string content);
        ICollection<ImageEntity> Order(string type,string content);
        ImageEntity One(int id);

        bool Delete(int id);
        int CountRequested();
        bool Accept(int id);
        bool Reject(int id);
    }
    public class ImageRepository : IImageRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ImageRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ICollection<ImageEntity> All()
        {
            return _dbContext.Images.Select(n => n).ToList();
        }
        public ICollection<ImageEntity> All(StatusEnum status)
        {
            return _dbContext.Images.Select(n => n).Where(n=>n.Status == status).ToList();
        }

        public ICollection<ImageEntity> All(string id)
        {
            return _dbContext.Images.Include(n =>n.pageUser).Select(n => n).Where(n=>n.UserForeignKey == id).ToList();
        }

        public ICollection<ImageEntity> Search(string content)
        {
            return _dbContext.Images.Select(n => n).Where(n => n.Title.ToLower().Contains(content.ToLower()) && n.Status == StatusEnum.Accepted).ToList();
        }

        public ICollection<ImageEntity> Order(string type,string content = null)
        {
            if(content != null)
            {
                if(type == "asc")
                {
                    return _dbContext.Images.Select(n => n).Where(n => n.Title.ToLower().Contains(content.ToLower()) && n.Status == StatusEnum.Accepted).OrderBy(n=>n.Price).ToList();
                }
                else
                {
                    return _dbContext.Images.Select(n => n).Where(n => n.Title.ToLower().Contains(content.ToLower()) && n.Status == StatusEnum.Accepted).OrderByDescending(n => n.Price).ToList();
                }
            }
            else
            {
                if (type == "asc")
                {
                    return _dbContext.Images.Select(n => n).Where(n => n.Status == StatusEnum.Accepted).OrderBy(n => n.Price).ToList();
                }
                else
                {
                    return _dbContext.Images.Select(n => n).Where(n => n.Status == StatusEnum.Accepted).OrderByDescending(n => n.Price).ToList();
                }
            }
        }

        public bool Add(ImageEntity entity)
        {

            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            _dbContext.Images.Add(entity);
            return _dbContext.SaveChanges() > 0;
        }

        public int CountRequested()
        {
            return _dbContext.Images.Count(n => n.Status == Enums.StatusEnum.InProgress);
        }
        public ImageEntity One(int id)
        {
            return _dbContext.Images.FirstOrDefault(n => n.Id == id) ?? new ImageEntity();
        }

        public bool Delete(int id)
        {
            var entity = One(id);
            if (entity.Title != null && entity.Title != "")
                _dbContext.Images.Remove(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public bool Accept(int id)
        {
            var entity = One(id);
            entity.Status = Enums.StatusEnum.Accepted;
            _dbContext.Images.Update(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public bool Reject(int id)
        {
            var entity = One(id);
            entity.Status = Enums.StatusEnum.Rejected;
            _dbContext.Images.Update(entity);

            return _dbContext.SaveChanges() > 0;
        }

    }
}

