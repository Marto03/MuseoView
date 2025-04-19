using Database.DTOs;
using Database.Models;

namespace BusinessLayer.Interfaces
{
    public interface IMuseumService
    {
        Task<List<RegionDTO>> GetAllRegionsAsync();
        Task<List<MuseumDTO>> GetMuseumsDTOByRegionAsync(int regionId);
        Task<MuseumModel> GetMuseumByIdAsync(int museumId);
        Task<string> GetRegionNameByIdAsync(int regionId);
        Task<List<MuseumModel>> GetAllMuseumsAsync();
        Task<List<MuseumDTO>> GetAllMuseumNamesAsync(Dictionary<int, string> regionImageMapper);
        Task<string> GetRegionNameForPictureByMuseumId(int museumId, Dictionary<int, string> regionImageMapper);
        Task<int> AddMuseumAsync(MuseumModel museum);
        Task<int> DeleteMuseumAsync(MuseumModel museum);
        Task<int> UpdateMuseumAsync(MuseumModel museum);
    }
}
