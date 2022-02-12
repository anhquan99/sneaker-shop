﻿using WebApplication1.Data;
using WebApplication1.Entities;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Repository.Services
{
    public class ProductInventoryService : BaseService<ProductInventory, int>
    {
        public ProductInventoryService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override ProductInventory Update(ProductInventory t)
        {
            var result = entitySet.Where(x => x.Id == t.Id).SingleOrDefault();
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
