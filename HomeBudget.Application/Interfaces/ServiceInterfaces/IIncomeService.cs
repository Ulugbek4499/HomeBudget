using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeBudget.Domain.Models.Incomes;
namespace HomeBudget.Application.Interfaces.ServiceInterfaces
{
    public interface IIncomeService
    {
        ValueTask<Income> AddIncomeAsync(Income income);
        ValueTask<Income> GetIncomeByIdAsync(Guid id);
        IQueryable<Income> GetAllIncomeAsync();
        ValueTask<Income> UpdateIncomeAsync(Income income);
        ValueTask<Income> DeleteIncomeAsync(Guid id);
    }
}
