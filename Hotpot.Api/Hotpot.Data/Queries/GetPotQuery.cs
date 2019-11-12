using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Hotpot.Data
{
    public class GetPotQuery : IGetPotQuery
    {
        private readonly IConnectionStringProvider _connectionStringProvider;
        public GetPotQuery(IConnectionStringProvider connectionStringProvider)
        {
            _connectionStringProvider = connectionStringProvider;
        }
        public async Task<PotEntity> Execute(GetPotRequest potRequest)
        {
            var conn = new SqlConnection(_connectionStringProvider.GetConnection());

            return await conn.QuerySingleAsync<PotEntity>(Sql, new { PotId = potRequest.Id });
        }

        private static string Sql => @"            
            Select * FROM Pot WHERE Id = @PotId 
        ";
    }
}