using System.Collections.Generic;
using System.Threading.Tasks;
using TrabalhandoComTasks.Domain.Contracts.Repositories.Generic;
using TrabalhandoComTasks.Domain.Entities;

namespace TrabalhandoComTasks.Domain.Contracts.Repositories
{
    public interface IPessoaRepository : IRepositoryBase<Pessoa>
    {
        Task<IEnumerable<Pessoa>> GetAll();
        Task<Pessoa> Get(int idPessoa);
    }
}
