using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Counter
{
    internal static class Configuration
    {
        public static string GetFilePath()
        {
            string filePath = ConfigurationManager.AppSettings["FilePath"];
            if (string.IsNullOrEmpty("FilePath"))
                filePath = string.Empty;
            return filePath;
        }
    }
}
