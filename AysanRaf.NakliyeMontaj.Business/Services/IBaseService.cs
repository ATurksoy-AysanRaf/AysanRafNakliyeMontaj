using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AysanRaf.NakliyeMontaj.Business.Services
{
    public interface IBaseService<T> where T : class
    {
        Task<T?> GetByIdAsync(String id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> AddAsync(T entity);
        Task<bool> DeleteAsync(String id);
        Task<T> UpdateAsync(T entity);
    }
}
