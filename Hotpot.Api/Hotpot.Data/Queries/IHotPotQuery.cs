using System.Threading.Tasks;

namespace Hotpot.Data
{
    public interface IHotPotQuery<TEntity, in TRequest>
    {
        Task<TEntity> Execute(TRequest request);
    }
}