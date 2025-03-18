using Database.Data.Initialize;
using Database.Models;
using SQLite;
namespace Database.Data
{
    public class MuseumDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public MuseumDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            CreateTablesAsync().Wait();
            DatabaseSeeder.SeedAsync(_database).Wait(); // Инициализираме данните
        }

        private async Task CreateTablesAsync()
        {
            await _database.CreateTableAsync<CityModel>();
            await _database.CreateTableAsync<MuseumModel>();
            await _database.CreateTableAsync<RegionModel>();
            await _database.CreateTableAsync<TypeMuseumModel>();
            await _database.CreateTableAsync<MuseumImageModel>();
        }


        public async Task<List<T>> GetAllAsync<T>() where T : new()
        {
            return await _database.Table<T>().ToListAsync();
        }

        //public Task<List<MuseumModel>> GetMuseumsAsync()
        //{
        //    return _database.Table<MuseumModel>().ToListAsync();
        //}

        public Task<int> AddMuseumAsync(MuseumModel museum)
        {
            return _database.InsertAsync(museum);
        }

        public Task<int> DeleteMuseumAsync(MuseumModel museum)
        {
            return _database.DeleteAsync(museum);
        }

        public Task<int> UpdateMuseumAsync(MuseumModel museum)
        {
            return _database.UpdateAsync(museum);
        }
    }
}
