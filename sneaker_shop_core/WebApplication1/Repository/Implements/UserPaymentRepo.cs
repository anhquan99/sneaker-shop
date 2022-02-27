using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebApplication1.Repository.Implements
{
    public class UserPaymentRepo : BaseRepo<UserPayment, int>
    {
        public UserPaymentRepo(ApplicationDbContext dbContext, ILogger logger) : base(dbContext, logger)
        {
        }
        public async override Task<UserPayment> Update(UserPayment t)
        {
            try
            {
                var result = entitySet.Where(x => x.UserId == t.UserId && x.AccountNumber == t.AccountNumber).FirstOrDefault();
                if (result == null)
                {
                    return null;
                }
                result = t;
                await dbContext.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return null;
            }
        }
    }
}
