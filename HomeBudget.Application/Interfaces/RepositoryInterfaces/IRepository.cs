using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Application.Interfaces.RepositoryInterfaces
{
    public interface IRepository<T> where T : class
    {
        ValueTask<T> AddAsync(T entity);
        ValueTask<T> GetByIdAsync(Guid id);
        IQueryable<T> GetAll();
        ValueTask<T> UpdateAsync(T entity);
        ValueTask<T> DeleteAsync(T entity);
    }
}
