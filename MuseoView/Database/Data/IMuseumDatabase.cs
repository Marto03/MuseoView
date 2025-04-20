using Database.DTOs;
using Database.Models;

namespace Database.Data
{
    internal interface IMuseumDatabase
    {
        Task InitializeDatabaseAsync();
        Task<List<T>> GetAllAsync<T>() where T : new();
        Task<List<RegionDTO>> GetAllRegionsAsync();
        Task<List<MuseumModel>> GetMuseumsByRegionAsync(string regionName);
        Task<List<MuseumDTO>> GetMuseumsDTOByRegionAsync(int regionID);
        Task<MuseumModel> GetMuseumByIdAsync(int museumId);
        Task<string?> GetRegionNameByIdAsync(int regionId);
        Task<List<MuseumModel>> GetAllMuseumsAsync();
        Task<List<MuseumDTO>> GetAllMuseumNamesAsync(Dictionary<int, string> regionImageMapper);
        Task<string> GetRegionNameForPictureByMuseumId(int museumId, Dictionary<int, string> regionImageMapper);
        Task<int> AddMuseumAsync(MuseumModel museum);
        Task<int> DeleteMuseumAsync(MuseumModel museum);
        Task<int> UpdateMuseumAsync(MuseumModel museum);
        Task InsertAllAsync<T>(IEnumerable<T> items) where T : new();
    }
}
