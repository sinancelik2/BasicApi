using App.Application.Interfaces.Repositories;
using App.Domain.Entities;
using App.Persistence.Context;

namespace App.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}