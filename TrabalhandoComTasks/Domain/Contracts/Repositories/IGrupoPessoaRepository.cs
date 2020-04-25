using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrabalhandoComTasks.Domain.Contracts.Repositories.Generic;
using TrabalhandoComTasks.Domain.Entities;

namespace TrabalhandoComTasks.Domain.Contracts.Repositories
{
    public interface IGrupoPessoaRepository : IRepositoryBase<GrupoPessoa>
    {
        Task<IEnumerable<GrupoPessoa>> GetAll();
        Task<GrupoPessoa> Get(int idGrupoPessoa);
    }
}
