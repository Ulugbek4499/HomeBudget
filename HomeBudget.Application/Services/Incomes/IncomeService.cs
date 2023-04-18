using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeBudget.Application.Interfaces.RepositoryInterfaces;
using HomeBudget.Application.Interfaces.ServiceInterfaces;
using HomeBudget.Domain.Models.Incomes;

namespace HomeBudget.Application.Services.Incomes
{
    public class IncomeService : IIncomeService
    {
        private readonly IIncomeRepository incomeRepository;

        public IncomeService(IIncomeRepository incomeRepository)=>
            this.incomeRepository = incomeRepository;

        public async ValueTask<Income> AddIncomeAsync(Income income)
        {
            return await this.incomeRepository.AddAsync(income);
        }

        public async ValueTask<Income> DeleteIncomeAsync(Guid id)
        {
            Income maybeIncome= await this.incomeRepository.GetByIdAsync(id);

            return await this.incomeRepository.DeleteAsync(maybeIncome);
        }

        public IQueryable<Income> GetAllIncomeAsync()
        {
            return this.incomeRepository.GetAll();
        }

        public async ValueTask<Income> GetIncomeByIdAsync(Guid id)
        {
            return await incomeRepository.GetByIdAsync(id);
        }

        public async ValueTask<Income> UpdateIncomeAsync(Income income)
        {
            return await this.incomeRepository.UpdateAsync(income);
        }
    }
}
