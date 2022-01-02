using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class ConnectionStringProvider
    {
        public static string GetConnectionString (String name) // returns connection string using database name
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
