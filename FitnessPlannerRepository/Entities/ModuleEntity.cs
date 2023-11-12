using System.ComponentModel.DataAnnotations;

namespace FitnessPlannerRepository.Entities
{
    public class ModuleEntity : EntityBase
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Text { get; set; }
        
        [Required]
        public byte[] Bytes { get; set; }
        
        [Required]
        public string Filename { get; set; }
        
        [Required]
        public string ContentType { get; set; }

        public Guid CalendarId { get; set; }
        public CalendarEntity Calendar { get; set; }
    }
}
