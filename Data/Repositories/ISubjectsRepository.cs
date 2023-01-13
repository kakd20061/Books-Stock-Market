using Books_Stock_Market.Data.Entities;

namespace Books_Stock_Market.Data.Repositories
{
    public interface ISubjectRepository
    {
        ICollection<SubjectEntity> All();

        int Count();
        int CountRequested();

        SubjectEntity One(int id);

        bool Add(SubjectEntity entity);

        bool Delete(int id);

        bool Accept(int id);
        SubjectEntity Edit(SubjectEntity entity);
    }

    public class SubjectRepository : ISubjectRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public SubjectRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool Add(SubjectEntity entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            _dbContext.Subjects.Add(entity);
            return _dbContext.SaveChanges() > 0;
            //naprawić
        }

        public ICollection<SubjectEntity> All()
        {
            return _dbContext.Subjects.Select(n => n).ToList();
        }

        public int Count()
        {
            return _dbContext.Subjects.Count();
        }

        public int CountRequested()
        {
            return _dbContext.Subjects.Count(n=>n.IsChecked == false);
        }

        public bool Delete(int id)
        {
            var entity = One(id);
            if (entity.SubjectName != null && entity.SubjectName != "")
                _dbContext.Subjects.Remove(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public bool Accept(int id)
        {
            var entity = One(id);
            entity.IsChecked = true;
            _dbContext.Subjects.Update(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public SubjectEntity Edit(SubjectEntity entity)
        {
            var dbEntity = One(entity.Id);

            dbEntity.SubjectName = entity.SubjectName;

            entity.UpdatedAt = DateTime.UtcNow;

            _dbContext.Subjects.Update(dbEntity);

            _dbContext.SaveChanges();

            return dbEntity;
        }

        public SubjectEntity One(int id)
        {
            return _dbContext.Subjects.FirstOrDefault(n => n.Id == id) ?? new SubjectEntity();
        }

    }
}
