using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetPrg.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<int> AddAsync(T t);
        Task<int> UpdateAsync(T t);
        Task<int> DeleteAsync(T t);
        Task<int> DeactivateAsync(T t);
        Task<T> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
    }
}
