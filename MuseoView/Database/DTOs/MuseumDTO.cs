namespace Database.DTOs
{
    public class MuseumDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }
        public string? RegionName { get; set; }  // ⬅️ Добавяме това
        public string? MuseumType { get; set; }  // ⬅️ Добавяме това
        public string MainImagePath => $"MuseumPictures/{RegionName}_{Id}_main.jpg"; // трябва да е на латиница започвайки и завършвайки с буква * blagoevgrad_41_1_b   *
        public string ImagePath => $"MuseumPictures/{RegionName}_{Id}_1{RegionName[0]}.jpg"; // трябва да е на латиница започвайки и завършвайки с буква * blagoevgrad_41_1_b   *

    }

}
