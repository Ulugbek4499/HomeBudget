using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeBudget.Domain.Models.Expences;

namespace HomeBudget.Application.Interfaces.RepositoryInterfaces
{
    public interface IExpenceRepository:IRepository<Expence>
    {
    }
}
