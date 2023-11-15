using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AysanRaf.NakliyeMontaj.DataAccess.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(String id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> AddAsync(T entity);

        Task<bool> SaveAllAsync();

        Task<bool> DeleteAsync(String id);
        Task<T> UpdateAsync(T entity);
    }
}
