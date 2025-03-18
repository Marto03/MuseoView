using SQLite;

namespace Database.Models
{
    public class TypeMuseumModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public MuseumTypeEnum Type { get; set; }

    }
}
