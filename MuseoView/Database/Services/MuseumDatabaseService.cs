using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Services
{
    public class MuseumDatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public MuseumDatabaseService()
        {
            _database = new SQLiteAsyncConnection(DatabaseConfig.DbPath);
        }

        public async Task<List<string>> GetAllRegionsAsync()
        {
            return await _database.QueryScalarsAsync<string>("SELECT DISTINCT Name FROM Regions");
        }
    }
}
