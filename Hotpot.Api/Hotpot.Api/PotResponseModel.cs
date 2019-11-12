using System;
using HotPot.Domain;

namespace Hotpot.Api.Controllers
{
    public class PotResponseModel
    {
        public string Name { get; set; }
        public Guid Id { get; set; }

        public PotResponseModel(Pot pot)
        {
            Name = pot.Name;
            Id = pot.Id;
        }
    }
}