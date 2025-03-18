using SQLite;

namespace Database.Models
{
    public class MuseumImageModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        // Път към изображението, ако съхраняваш файлове локално
        public string ImagePath { get; set; }

        // Бинарни данни за изображението (ако се съхранява в базата данни)
        public byte[] ImageData { get; set; }

        // Външен ключ към музея
        public int MuseumId { get; set; }
        
        // Навигационно свойство към музея
        //public Museum Museum { get; set; }
    }
}
