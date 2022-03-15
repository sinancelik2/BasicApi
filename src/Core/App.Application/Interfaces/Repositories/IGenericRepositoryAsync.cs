using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using App.Domain.Common;
using App.Domain.Entities;

namespace App.Application.Interfaces.Repositories
{
    public interface IGenericRepositoryAsync<T> where T : BaseEntity 
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetProductByIdAsync(Guid Id);
        Task<T> AddAsync(T entity);
    }
}