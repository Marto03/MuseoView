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
            DatabaseConfig.CopyDatabaseToDownloads();
            //CreateTablesAsync().Wait();
            //DatabaseSeeder.SeedAsync(_database).Wait(); // Инициализираме данните
            //InitializeDatabaseAsync(); // Извикваме асинхронния метод за инициализация
        }
        public async Task InitializeDatabaseAsync()
        {
            await CreateTablesAsync(); // Ще изчакаме таблиците да се създадат
            await DatabaseSeeder.SeedAsync(_database); // Ще изчакаме данните да се инициализират
        }
        private async Task CreateTablesAsync()
        {
            var tasks = new List<Task>
            {
                _database.CreateTableAsync<CityModel>(),
                _database.CreateTableAsync<MuseumModel>(),
                _database.CreateTableAsync<RegionModel>(),
                _database.CreateTableAsync<MuseumImageModel>()
            };

            await Task.WhenAll(tasks);
            //await _database.CreateTableAsync<CityModel>();
            //await _database.CreateTableAsync<MuseumModel>();
            //await _database.CreateTableAsync<RegionModel>();
            //await _database.CreateTableAsync<TypeMuseumModel>();
            //await _database.CreateTableAsync<MuseumImageModel>();
        }


        public async Task<List<T>> GetAllAsync<T>() where T : new()
        {
            return await _database.Table<T>().ToListAsync();
        }
        //public async Task<List<string>> GetAllRegionsAsync()
        //{
        //    // Извършваме SQL заявка и връщаме списък от имената на регионите
        //    var regions = await _database.QueryAsync<RegionModel>("SELECT Name FROM RegionModel");

        //    // Извличаме имената от резултата и ги връщаме като списък от string
        //    return regions.Select(r => r.Name).ToList();
        //}
        public async Task<List<string>> GetAllRegionsAsync()
        {
            var regions = await _database.Table<RegionModel>().ToListAsync();
            return regions.Select(r => r.Name).ToList(); // Връщаме само имената на регионите
        }
        public async Task<List<MuseumModel>> GetMuseumsByRegionAsync(string regionName)
        {
            return await _database.Table<MuseumModel>()
                .Where(m => m.Name == regionName) // Филтрираме по региона
                .ToListAsync();
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
