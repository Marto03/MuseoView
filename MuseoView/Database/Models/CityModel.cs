using SQLite;

namespace Database.Models
{
    public class CityModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull, Unique]
        public string Name { get; set; }

        public int RegionId { get; set; }
    }
}
