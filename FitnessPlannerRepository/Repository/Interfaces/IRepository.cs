﻿using FitnessPlannerRepository.Entities.Interfaces;

namespace FitnessPlannerRepository.Repository.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<ICollection<T>> GetAll();
        Task<T> Get(Guid id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(Guid id);
    }
}