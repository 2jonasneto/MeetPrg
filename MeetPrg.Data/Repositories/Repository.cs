using MeetPrg.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetPrg.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Task<int> AddAsync(T t)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeactivateAsync(T t)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(T t)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(T t)
        {
            throw new NotImplementedException();
        }
    }
}
