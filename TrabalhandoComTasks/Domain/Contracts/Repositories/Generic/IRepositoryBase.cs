using System.Threading.Tasks;
using TrabalhandoComTasks.Domain.Shared.Entities;

namespace TrabalhandoComTasks.Domain.Contracts.Repositories.Generic
{
    public interface IRepositoryBase<T> where T : Entity
    {
        Task<T> Save(T e);
        Task<T> Update(T e);
        Task<T> Delete(T e);
    }
}
