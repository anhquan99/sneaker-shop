using WebApplication1.Data;
using WebApplication1.Entities;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Repository.Services
{
    public class PaymentDetailService : BaseService<PaymentDetail, int>
    {
        public PaymentDetailService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override PaymentDetail Update(PaymentDetail t)
        {
            var result = entitySet.Where(x => x.Id == t.Id).FirstOrDefault();
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
