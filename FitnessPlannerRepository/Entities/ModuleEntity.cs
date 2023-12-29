using System.ComponentModel.DataAnnotations;

namespace FitnessPlannerRepository.Entities
{
    public class ModuleEntity : EntityBase
    {
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Text { get; set; }
        
        [Required]
        public string Base64Img { get; set; }
        
        [Required]
        public string Filename { get; set; }
        
        [Required]
        public string ContentType { get; set; }

        public string? Day { get; set; }

        public Guid? CalendarId { get; set; }
        public CalendarEntity? Calendar { get; set; }
    }
}
