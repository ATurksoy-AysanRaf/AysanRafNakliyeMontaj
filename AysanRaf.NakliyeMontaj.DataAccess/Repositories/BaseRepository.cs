
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AysanRaf.NakliyeMontaj.DataAccess.Repositories
{
    public class BaseRepository<T>: IBaseRepository<T> where T : class
    {
        private readonly aysanrafpopsepdevelopment_2023_09_10_05_45Context _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(aysanrafpopsepdevelopment_2023_09_10_05_45Context context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task<T?> GetByIdAsync(String id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        //public async Task<T> AddAsync(T entity)
        //{



        //    await _dbSet.AddAsync(entity);

        //    return entity;
        //}
        public async Task<T> AddAsync(T entity)
        {
            PropertyInfo idProperty = entity.GetType().GetProperty("id");

            if (idProperty != null && idProperty.PropertyType == typeof(Guid))
            {
                idProperty.SetValue(entity, Guid.NewGuid());
            }

            await _dbSet.AddAsync(entity);

            return entity;
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(String id)
        {
            var entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

       
    }
}
