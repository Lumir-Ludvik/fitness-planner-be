
namespace FitnessPlannerMapping.ModelDTOs
{
    public class CalendarDTO
    {
        public ICollection<ModuleDTO> Monday { get; set; } = new List<ModuleDTO>();
        public ICollection<ModuleDTO> Tuesday { get; set; } = new List<ModuleDTO>();
        public ICollection<ModuleDTO> Wednesday { get;set; } = new List<ModuleDTO>();
        public ICollection<ModuleDTO> Thursday { get; set; } = new List<ModuleDTO>();
        public ICollection<ModuleDTO> Friday { get; set; } = new List<ModuleDTO>();
        public ICollection<ModuleDTO> Saturday { get; set;} = new List<ModuleDTO>();
        public ICollection<ModuleDTO> Sunday { get; set; } = new List<ModuleDTO>();
    }
}
