using System;
using Dapper;
using Hotpot.Data;
using Microsoft.Data.SqlClient;

namespace HotPot.Database
{
    public class HotPotDatabaseInit
    {
        private readonly IConnectionStringProvider _connectionStringProvider;
        public HotPotDatabaseInit(IConnectionStringProvider connectionStringProvider)
        {
            _connectionStringProvider = connectionStringProvider;
        }

        public void Init()
        {
            var conn = new SqlConnection(_connectionStringProvider.GetMasterConnection());
            conn.Query(CreateDatabase);

            var hotpotConn = new SqlConnection(_connectionStringProvider.GetConnection());
            hotpotConn.Query(CreatePotTable);
            hotpotConn.Query(InsertPotTestData);
        }

        private static string CreateDatabase => @"   
            IF  NOT EXISTS (SELECT * FROM sys.databases WHERE name = N'HotPot')
            BEGIN
                CREATE DATABASE [HotPot]
            END;
        ";

        private static string CreatePotTable => @"    
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Pot' and xtype='U')
            BEGIN
                CREATE TABLE Pot (
                    Id uniqueidentifier,
                    Name varchar(255)
                )
            END;
        ";

        private static string InsertPotTestData => @" 
            Delete from Pot
            Insert Into Pot(Id,Name)Values('86af164c-c062-40c0-a76d-743073ee8601','Test')
        ";
    }
}
