using SQLite;

namespace Database.Models
{
    public class MuseumModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string Name { get; set; }

        public int RegionId { get; set; }
        public int TypeStatusId { get; set; } // какъв е типът му.

        [MaxLength(0)]
        public string Description { get; set; } // Информация за самия музей

        [NotNull]
        public string Location { get; set; }
        public string OpeningHours { get; set; } // работно време

        //public int Images { get; set; }


        //public string VirtualTourUrl { get; set; }
        //public string StatusId { get; set; } // дали е в ремонт или е активен.

    }
}
