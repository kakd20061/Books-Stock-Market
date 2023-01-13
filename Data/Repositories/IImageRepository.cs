using Books_Stock_Market.Data.Entities;

namespace Books_Stock_Market.Data.Repositories
{
    public interface IImageRepository
    {
        bool Add(ImageEntity entity);
        ICollection<ImageEntity> All();
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

        public bool Add(ImageEntity entity)
        {

            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            _dbContext.Images.Add(entity);
            return _dbContext.SaveChanges() > 0;
        }

    }
}

