using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeBudget.Application.Interfaces.RepositoryInterfaces;
using HomeBudget.Application.Interfaces.ServiceInterfaces;
using HomeBudget.Domain.Models.Expences;

namespace HomeBudget.Application.Services.Expences
{
    public class ExpenceService : IExpenceService
    {
        private readonly IExpenceRepository expenceRepository;

        public ExpenceService(IExpenceRepository expenceRepository)=>
            this.expenceRepository = expenceRepository;

        public async ValueTask<Expence> AddExpenceAsync(Expence expence)
        {
            return await this.expenceRepository.AddAsync(expence);
        }

        public async ValueTask<Expence> DeleteExpenceAsync(Guid id)
        {
            Expence maybeExpence= await this.expenceRepository.GetByIdAsync(id);

            return await this.expenceRepository.DeleteAsync(maybeExpence);
        }

        public IQueryable<Expence> GetAllExpenceAsync()
        {
            return this.expenceRepository.GetAll();
        }

        public async ValueTask<Expence> GetExpenceByIdAsync(Guid id)
        {
            return await this.expenceRepository.GetByIdAsync(id);
        }

        public async ValueTask<Expence> UpdateExpenceAsync(Expence expence)
        {
            return await this.expenceRepository.UpdateAsync(expence);
        }
    }
}
