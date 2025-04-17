using Database.Data.Initialize;
using Database.DTOs;
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
            
            //DatabaseConfig.CopyDatabaseToDownloads(); --- За копиране на базата в Downloads

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
        public async Task<List<RegionDTO>> GetAllRegionsAsync()
        {
            var regions = await _database.Table<RegionModel>().ToListAsync();

            return regions
                .Select(r => new RegionDTO
                {
                    Id = r.Id,
                    Name = r.Name
                })
                .ToList();
        }
        public async Task<List<MuseumModel>> GetMuseumsByRegionAsync(string regionName)
        {
            return await _database.Table<MuseumModel>()
                .Where(m => m.Name == regionName) // Филтрираме по региона
                .ToListAsync();
        }
        public async Task<List<MuseumDTO>> GetMuseumsDTOByRegionAsync(int regionID)
        {
            var museums = await _database.Table<MuseumModel>().Where(m=> m.RegionId == regionID).ToListAsync();
            var regions = await _database.Table<RegionModel>().ToListAsync(); // ⬅️ Взимаме всички региони
            return museums.Select(m =>
            {
                var region = regions.FirstOrDefault(r => r.Id == m.RegionId);

                return new MuseumDTO
                {
                    Id = m.Id,
                    Name = m.Name,
                    RegionId = m.RegionId,
                    RegionName = region?.Name // ⬅️ Включваме името на региона
                };
            }).ToList();
            // Филтрираме по региона
        }
        public async Task<MuseumModel> GetMuseumByIdAsync(int museumId)
        {
            var museum = await _database.Table<MuseumModel>().Where(m=> m.Id == museumId).ToListAsync();
            return museum?.FirstOrDefault();
                 // Филтрираме по региона
        }
        public async Task<string?> GetRegionNameByIdAsync(int regionId)
        {
            var region = await _database.Table<RegionModel>()
                                        .FirstOrDefaultAsync(r => r.Id == regionId);

            return region?.Name;
        }

        public async Task<List<MuseumModel>> GetAllMuseumsAsync()
        {
            var museums = await _database.Table<MuseumModel>() // Филтрираме по региона
                .ToListAsync();
            return await _database.Table<MuseumModel>() // Филтрираме по региона
                .ToListAsync();
        }
        public async Task<List<MuseumDTO>> GetAllMuseumNamesAsync()
        {
            var museums = await _database.Table<MuseumModel>().ToListAsync(); // Взимаме всички

            return museums.Select(m => new MuseumDTO
            {
                Id = m.Id,
                Name = m.Name,
                RegionId = m.RegionId
            }).ToList();
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
