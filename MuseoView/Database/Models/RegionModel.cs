using SQLite;

namespace Database.Models
{
    public class RegionModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull, Unique]
        public string Name { get; set; }
    }
}
