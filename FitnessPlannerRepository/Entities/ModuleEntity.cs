using FitnessPlannerRepository.Entities.@base;
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

        public Guid DayId { get; set; }
        public DayBaseEntity? Day { get; set; }
    }
}
