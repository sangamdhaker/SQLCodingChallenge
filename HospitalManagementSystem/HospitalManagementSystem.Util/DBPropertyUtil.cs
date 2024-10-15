using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using System.IO;

namespace HospitalManagementSystem.Util
{
    public static class DBPropertyUtil
    {
        // Method to get connection string
        public static string GetConnectionString()
        {
            // Construct and return the connection string directly
            return "Server=localhost;Database=HospitalManagement;User Id=root;Password=root;Port=3307;";
        }
    }
}
