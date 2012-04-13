using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Linq.Mapping;

namespace Steag.Data
{
    internal class DataContext: System.Data.Linq.DataContext
    {
        public DataContext(string connectionString)
            :base(connectionString)
        {
            
        }

        public DataContext(IDbConnection connection)
            :base(connection)
        {
            
        }

        public DataContext(IDbConnection connection, MappingSource source)
            :base(connection, source)
        {
            
        }
    }
}
