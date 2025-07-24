using DataAcessesLayer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessesLayer.Data
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}
