using Database.Data.Initialize;
using Database.DTOs;
using Database.Models;
using SQLite;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BusinessLayer")]
namespace Database.Data
{
    internal class MuseumDatabase : IMuseumDatabase
    {
        private readonly SQLiteAsyncConnection _database;
        public MuseumDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
        }
        public async Task InitializeDatabaseAsync()
        {
            await CreateTablesAsync(); // Ще изчакаме таблиците да се създадат
            await DatabaseSeeder.SeedAsync(_database); // Ще изчакаме данните да се инициализират
        }
        public async Task InsertAllAsync<T>(IEnumerable<T> items) where T : new()
        {
            await _database.InsertAllAsync(items);
        }
        private async Task CreateTablesAsync()
        {
            var tasks = new List<Task>
            {
                _database.CreateTableAsync<CityModel>(),
                _database.CreateTableAsync<MuseumModel>(),
                _database.CreateTableAsync<RegionModel>()
            };

            await Task.WhenAll(tasks);
        }


        public async Task<List<T>> GetAllAsync<T>() where T : new()
        {
            return await _database.Table<T>().ToListAsync();
        }
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
                    RegionName = region?.Name, // ⬅️ Включваме името на региона
                    MuseumType = Enum.GetName(typeof(MuseumTypeEnum), m.TypeStatusId)
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
        public async Task<List<MuseumDTO>> GetAllMuseumNamesAsync(Dictionary<int, string> regionImageMapper)
        {
            var museums = await _database.Table<MuseumModel>().ToListAsync();
            var regions = await _database.Table<RegionModel>().ToListAsync(); // ⬅️ Взимаме всички региони
            return museums.Select(m =>
            {
                var region = regions.FirstOrDefault(r => r.Id == m.RegionId);

                return new MuseumDTO
                {
                    Id = m.Id,
                    Name = m.Name,
                    RegionId = m.RegionId,
                    RegionName = region?.Name, // ⬅️ Включваме името на региона
                    MuseumType = Enum.GetName(typeof(MuseumTypeEnum), m.TypeStatusId),
                    RegionPictureName = regionImageMapper.FirstOrDefault(r => r.Key == m.RegionId).Value
                };
            }).ToList();
        }
        public async Task<string> GetRegionNameForPictureByMuseumId(int museumId, Dictionary<int, string> regionImageMapper)
        {
            // Взимаме музея от базата
            var museum = await _database.Table<MuseumModel>()
                                         .FirstOrDefaultAsync(m => m.Id == museumId);

            if (museum == null)
                return null;

            // Взимаме RegionId на музея и търсим в речника
            if (regionImageMapper.TryGetValue(museum.RegionId, out var pictureName))
            {
                return pictureName;
            }

            return null;
        }


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
