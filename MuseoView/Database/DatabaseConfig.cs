using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class DatabaseConfig
    {
        // Път до базата данни
        public static string DbPath
        {
            get
            {
                // Използваме директорията на приложението за съхранение на базата данни
                string folderPath = FileSystem.AppDataDirectory;
                return Path.Combine(folderPath, "museumDatabase.db");
            }
        }
    }
}
