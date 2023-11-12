using FitnessPlannerRepository.Entities.Interfaces;

namespace FitnessPlannerRepository.Entities
{
    public class EntityBase : IEntity
    {
        public Guid Id { get; set; }
    }
}
