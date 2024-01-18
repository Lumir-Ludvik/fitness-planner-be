
namespace FitnessPlannerMapping.ModelDTOs
{
    public class ModuleDTO
    {
        public required string Title { get; set; }

        public required string Text { get; set; }

        public string? Base64Img { get; set; }

        public string? Filename { get; set; }

        public string? ContentType { get; set; }

        public Days? Day { get; set; }
    }
}
