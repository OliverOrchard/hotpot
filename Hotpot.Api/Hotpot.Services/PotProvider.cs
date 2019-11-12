using System;
using System.Threading.Tasks;
using Hotpot.Data;
using HotPot.Domain;

namespace Hotpot.Services
{
    public class PotProvider : IPotProvider
    {
        private readonly IPotRepository _potRepository;

        public PotProvider(IPotRepository potRepository) => _potRepository = potRepository;

        public async Task<Pot> GetPot(Guid id)
        {
            var potEntity = await _potRepository.GetByIdAsync(id);
            return new Pot(){Id = potEntity.Id, Name = potEntity.Name};
        }
    }
}