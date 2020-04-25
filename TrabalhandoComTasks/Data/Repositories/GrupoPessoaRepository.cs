using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhandoComTasks.Data.Contexts;
using TrabalhandoComTasks.Data.Repositories.Generic;
using TrabalhandoComTasks.Domain.Contracts.Repositories;
using TrabalhandoComTasks.Domain.Entities;

namespace TrabalhandoComTasks.Data.Repositories
{
    public class GrupoPessoaRepository : RepositoryBase<GrupoPessoa>, IGrupoPessoaRepository
    {
        public GrupoPessoaRepository(TasksContext context) : base(context)
        {
        }

        public async Task<GrupoPessoa> Get(int idGrupoPessoa)
        {
            var result = this._context.GrupoPessoa.FirstOrDefault(p => p.IdGrupoPessoa == idGrupoPessoa);

            return await Task.FromResult(result);
        }

        public async Task<IEnumerable<GrupoPessoa>> GetAll()
        {
            return await Task.FromResult(this._context.GrupoPessoa);
        }
    }
}
