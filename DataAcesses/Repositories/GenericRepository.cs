using DataAcessesLayer.Contract;
using DataAcessesLayer.Data;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessesLayer.Repositories
{
    public class TableRepository<T> : ITableRepository<T> where T:BaseTable
    {
        private readonly ShippingDbContext context;
        private readonly DbSet<T> dbSet;

        public TableRepository(ShippingDbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        public bool Add(T entity)
        {
            try
            {
                entity.CreatedDate = DateTime.Now;
                entity.CurrentState = 1;
                dbSet.Add(entity);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                // Log the exception if necessary
                return false;
            }

        }

        public bool ChangeStatus(Guid id, int status = 1)
        {
            var entity = dbSet.Find(id);
            if (entity == null) 
                return false;

            entity.CurrentState = status;
            entity.UpdatedDate = DateTime.UtcNow;
            return context.SaveChanges() > 0;
        }

        public bool Delete(Guid id)
        {
            try
            {
                var entity = dbSet.Find(id);
                if (entity == null)
                    return false;

                dbSet.Remove(entity);
                return context.SaveChanges() > 0;

            }
            catch (Exception ex)
            {
                // Log the exception if necessary
                return false;
            }

        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(Guid id)
        {
            try
            {
                return dbSet.Where(a => a.Id == id).FirstOrDefault();

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                var existingEntity = GetById(entity.Id);
                if (existingEntity == null)
                    return false;
                entity.CreatedDate = existingEntity.CreatedDate; 
                entity.CreatedBy = existingEntity.CreatedBy;
                entity.CurrentState = existingEntity.CurrentState;
                entity.UpdatedBy = existingEntity.UpdatedBy; 
                entity.UpdatedDate = DateTime.Now;
                dbSet.Update(entity);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                // Log the exception if necessary
                return false;
            }

        }
    }


}
