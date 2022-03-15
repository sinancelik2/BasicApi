using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Entities;

namespace App.Application.Interfaces.Repositories
{
   public interface IProductRepository : IGenericRepositoryAsync<Product>
   {

   }
}
