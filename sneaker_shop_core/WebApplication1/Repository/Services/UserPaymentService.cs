using WebApplication1.Data;
using WebApplication1.Entities;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Repository.Services
{
    public class UserPaymentService : BaseService<UserPayment, int>
    {
        public UserPaymentService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override UserPayment Update(UserPayment t)
        {
            var result = entitySet.Where(x => x.UserId == t.UserId && x.AccountNumber == t.AccountNumber).FirstOrDefault();
            if (result == null)
            {
                return null;
            }
            result = t;
            dbContext.SaveChanges();    
            return result;
        }
    }
}
