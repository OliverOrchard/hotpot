using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotpot.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotpot.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PotController : ControllerBase
    {
        private readonly IPotProvider _potProvider;

        public PotController(IPotProvider potProvider)
        {
            _potProvider = potProvider;
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(Response<PotResponseModel>), 200)]
        public async Task<IActionResult> Get(Guid id)
        {
            var pot = await _potProvider.GetPot(id);

            if (pot == null)
            {
                return NotFound();
            }

            var response = new Response<PotResponseModel>()
            {
                Data = new PotResponseModel(pot)
            };

            return Ok(response);
        }

    }
}