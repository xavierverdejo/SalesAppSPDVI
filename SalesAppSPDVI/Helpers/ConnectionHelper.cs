using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAppSPDVI.Helpers
{
    class ConnectionHelper
    {
        public static string selectedSQL = "Sample";
        public static string[] stringNames = new string[] {"Sample", "Azure"};
        public static string cnnVal()
        {
            return ConfigurationManager.ConnectionStrings[selectedSQL].ConnectionString;
        }

    }
}
