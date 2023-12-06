
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
        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

  
        public async Task<T> AddAsync(T entity)
        {
            // Entity'nin Id özelliğini kontrol et
            PropertyInfo idProperty = typeof(T).GetProperty("Id");

            if (idProperty != null && idProperty.PropertyType == typeof(Guid))
            {
                // Eğer Id özelliği var ve tipi string ise yeni bir GUID oluştur
                idProperty.SetValue(entity, Guid.NewGuid());
            }

            // DbSet'e ekleyerek veritabanına kaydet
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }


        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(Guid id)
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
