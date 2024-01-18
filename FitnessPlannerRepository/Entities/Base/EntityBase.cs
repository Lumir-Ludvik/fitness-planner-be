using FitnessPlannerRepository.Entities.Interfaces;

namespace FitnessPlannerRepository.Entities.@base
{
    public class EntityBase : IEntity
    {
        public Guid Id { get; set; }
    }
}
