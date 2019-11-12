using System;
using System.Threading.Tasks;

namespace Hotpot.Data
{
    public class PotRepository : IPotRepository
    {
        private readonly IGetPotQuery _getPotQuery;
        public PotRepository(IGetPotQuery getPotQuery)
        {
            _getPotQuery = getPotQuery;
        }

        public async Task<PotEntity> GetByIdAsync(Guid id)
        {
            return await _getPotQuery.Execute(new GetPotRequest(){Id = id});
        }
    }
}
