using System.Text.Json;

namespace MuseoViewUI.ImageMapper
{
    public static class RegionImageMapper
    {

        private static Dictionary<string, List<string>> _imageData;
        public static Dictionary<int, string> RegionNames { get; set; } = new Dictionary<int, string>
        {
            { 1, "blagoevgrad" },
            { 2, "burgas" },
            { 3, "varna" },
            { 4, "velikoturnovo" },
            { 5, "vidin" },
            { 6, "vratsa" },
            { 7, "gabrovo" },
            { 8, "dobrich" },
            { 9, "kurdzhali" },
            { 10, "kyustendil" },
            { 11, "lovech" },
            { 12, "montana" },
            { 13, "pazardzhik" },
            { 14, "pernik" },
            { 15, "pleven" },
            { 16, "plovdiv" },
            { 17, "razgrad" },
            { 18, "ruse" },
            { 19, "silistra" },
            { 20, "sliven" },
            { 21, "smolyan" },
            { 22, "sofiagrad" },
            { 23, "sofiaoblast" },
            { 24, "starazagora" },
            { 25, "turgovishte" },
            { 26, "haskovo" },
            { 27, "shumen" },
            { 28, "yambol" }
        };
        public static async Task InitializeAsync()
        {
            if (_imageData != null) return;
            var test = FileSystem.OpenAppPackageFileAsync("museum_images.json");
            using var stream = await FileSystem.OpenAppPackageFileAsync("museum_images.json");
            using var reader = new StreamReader(stream);
            string json = await reader.ReadToEndAsync();
            _imageData = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json);
        }

        public static List<string> GetImages(string regionName, int museumId, bool getMainImage = false)
        {
            string key = $"{regionName}_{museumId}";
            if (_imageData != null && _imageData.TryGetValue(key, out var images))
            {
                var filteredImages = getMainImage
                    ? images.Where(img => img.Contains("main"))
                    : images.Where(img => !img.Contains("main"));

                return filteredImages
                    .Select(img => $"MuseumPictures/{img}")
                    .ToList();
            }

            return new List<string>();
            //if (_imageData != null && _imageData.TryGetValue(key, out var images) && !getMainImage)
            //{
            //    return images.Select(img => $"MuseumPictures/{img}").Where(r=>!r.Contains("main")).ToList();
            //}

            return new List<string>();
        }
    }
}
