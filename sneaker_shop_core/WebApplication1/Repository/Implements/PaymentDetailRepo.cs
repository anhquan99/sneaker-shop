using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebApplication1.Repository.Implements
{
    public class PaymentDetailRepo : BaseRepo<PaymentDetail, int>
    {
        public PaymentDetailRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<PaymentDetail> Update(PaymentDetail t)
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
