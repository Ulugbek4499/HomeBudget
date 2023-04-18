using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeBudget.Domain.Models.Expences;

namespace HomeBudget.Application.Interfaces.ServiceInterfaces
{
    public interface IExpenceService
    {
        ValueTask<Expence> AddExpenceAsync(Expence expence);
        ValueTask<Expence> GetExpenceByIdAsync(Guid id);
        IQueryable<Expence> GetAllExpenceAsync();
        ValueTask<Expence> UpdateExpenceAsync(Expence expence);
        ValueTask<Expence> DeleteExpenceAsync(Guid id);
    }
}
