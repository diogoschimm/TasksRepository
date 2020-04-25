using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhandoComTasks.Data.Contexts;
using TrabalhandoComTasks.Data.Repositories.Generic;
using TrabalhandoComTasks.Domain.Contracts.Repositories;
using TrabalhandoComTasks.Domain.Entities;

namespace TrabalhandoComTasks.Data.Repositories
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(TasksContext context) : base(context)
        {
        }

        public async Task<Pessoa> Get(int idPessoa)
        {
            var result =  this._context.Pessoa.FirstOrDefault(p => p.IdPessoa == idPessoa);

            return await Task.FromResult(result);
        }

        public async Task<IEnumerable<Pessoa>> GetAll()
        {
            return await Task.FromResult(this._context.Pessoa);
        }
    }
}
