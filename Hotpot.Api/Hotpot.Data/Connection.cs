using System;
using System.Collections.Generic;
using System.Text;

namespace Hotpot.Data
{
    public class ConnectionStringProvider : IConnectionStringProvider
    {
        public string GetConnection()
        {
            return @"Server=db;Database=HotPot;User=sa;Password=Your_password123;";
        }

        public string GetMasterConnection()
        {
            return @"Server=db;Database=master;User=sa;Password=Your_password123;";
        }
    }
}
