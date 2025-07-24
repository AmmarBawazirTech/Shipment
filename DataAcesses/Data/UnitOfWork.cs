using DataAcessesLayer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessesLayer.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShippingDbContext _dbContext;

        public UnitOfWork(ShippingDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

    }
}
