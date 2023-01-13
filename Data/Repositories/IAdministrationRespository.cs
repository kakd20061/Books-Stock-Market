using Books_Stock_Market.Data.Entities;

namespace Books_Stock_Market.Data.Repositories
{
    public interface IAdministrationRepository
    {
        ICollection<AdministrationEntity> All();

        int Count();

        AdministrationEntity One(int id);

        bool Add(AdministrationEntity entity);

        bool Delete(int id);

        bool AdminReturn(string email);
    }

    public class AdministrationRepository : IAdministrationRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public AdministrationRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool Add(AdministrationEntity entity)
        {
            var adminList = All();
            foreach(var admin in adminList)
            {
                if(admin.Email == entity.Email)
                {
                    return false;
                }
            }
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            _dbContext.Administration.Add(entity);
            return _dbContext.SaveChanges() > 0;
        }

        public ICollection<AdministrationEntity> All()
        {
            return _dbContext.Administration.Select(n => n).ToList();
        }

        public int Count()
        {
            return _dbContext.Administration.Count();
        }

        public bool Delete(int id)
        {
            var entity = One(id);
            if (entity.Email != null && entity.Email != "")
                _dbContext.Administration.Remove(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public bool AdminReturn(string email)
        {
            var admins = All();
            foreach (var admin in admins)
            {
                if (admin.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

        public AdministrationEntity One(int id)
        {
            return _dbContext.Administration.FirstOrDefault(n => n.Id == id) ?? new AdministrationEntity();
        }

    }
}
