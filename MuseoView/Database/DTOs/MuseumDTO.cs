namespace Database.DTOs
{
    public class MuseumDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }
        public string? RegionName { get; set; }
        public string? MuseumType { get; set; }
        public string? RegionPictureName { get; set; }
        public string MainImagePath => $"MuseumPictures/{RegionPictureName}_{Id}_main.jpg"; // трябва да е на латиница започвайки и завършвайки с буква * blagoevgrad_41_1_b   *

    }

}
