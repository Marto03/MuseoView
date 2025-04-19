using BusinessLayer.Interfaces;
using Database.Data;
using Database.DTOs;
using Database.Models;

namespace BusinessLayer.Services
{
    internal class MuseumService : IMuseumService
    {
        private readonly MuseumDatabase _db;

        public MuseumService(MuseumDatabase db)
        {
            _db = db;
        }

        public Task<List<RegionDTO>> GetAllRegionsAsync() => _db.GetAllRegionsAsync();

        public Task<List<MuseumDTO>> GetMuseumsDTOByRegionAsync(int regionId) => _db.GetMuseumsDTOByRegionAsync(regionId);

        public Task<MuseumModel> GetMuseumByIdAsync(int museumId) => _db.GetMuseumByIdAsync(museumId);

        public Task<string> GetRegionNameByIdAsync(int regionId) => _db.GetRegionNameByIdAsync(regionId);

        public Task<List<MuseumModel>> GetAllMuseumsAsync() => _db.GetAllMuseumsAsync();

        public Task<List<MuseumDTO>> GetAllMuseumNamesAsync(Dictionary<int, string> regionImageMapper) => _db.GetAllMuseumNamesAsync(regionImageMapper);

        public Task<string> GetRegionNameForPictureByMuseumId(int museumId, Dictionary<int, string> regionImageMapper) =>
            _db.GetRegionNameForPictureByMuseumId(museumId, regionImageMapper);

        public Task<int> AddMuseumAsync(MuseumModel museum) => _db.AddMuseumAsync(museum);

        public Task<int> DeleteMuseumAsync(MuseumModel museum) => _db.DeleteMuseumAsync(museum);

        public Task<int> UpdateMuseumAsync(MuseumModel museum) => _db.UpdateMuseumAsync(museum);
    }
}
