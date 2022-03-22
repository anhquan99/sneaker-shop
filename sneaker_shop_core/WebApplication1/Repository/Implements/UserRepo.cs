using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebApplication1.Repository.Implements
{
    public class UserRepo : BaseRepo<User , Guid>
    {
        public UserRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public async override Task<User> Update(User t)
        {
            var result = entitySet.Where(x => x.Id == t.Id).FirstOrDefault();
            if (result == null)
            {
                return null;
            }
            result = t;
            await dbContext.SaveChangesAsync();
            return result;
        }
    }
}
