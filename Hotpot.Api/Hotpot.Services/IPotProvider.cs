using System;
using System.Threading.Tasks;
using HotPot.Domain;

namespace Hotpot.Services
{
    public interface IPotProvider
    {
        Task<Pot> GetPot(Guid id);
    }
}