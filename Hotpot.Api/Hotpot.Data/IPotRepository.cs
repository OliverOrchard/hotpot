using System;
using System.Threading.Tasks;
using HotPot.Domain;

namespace Hotpot.Data
{
    public interface IPotRepository
    {
        Task<PotEntity> GetByIdAsync(Guid id);
    }
}