using Database.Models;
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

        public async Task<MuseumModel> GetMuseumByIdAsync(int museumId)
        {
            // Примерна заявка към базата данни
            var result = await _database.QueryAsync<MuseumModel>("SELECT * FROM Museums WHERE Id = ?", museumId);
            return result.FirstOrDefault(); // Вземаме първия елемент или null, ако няма такъв
        }
    }
}
