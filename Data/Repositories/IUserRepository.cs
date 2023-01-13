namespace Books_Stock_Market.Data.Repositories
{
    public interface IUserRepository
    {
        int Count();
    }
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Count()
        {
            return _dbContext.Users.Count();
        }
    }
}
