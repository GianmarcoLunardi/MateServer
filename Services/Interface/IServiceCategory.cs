using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;

namespace MakeSense.Services.Interface
{
  public  interface IServiceCategory
    {
        Task AddAsync(Category cat);
        Task AddRangeAsync(IEnumerable<Category> Cat);
        Task<Category> RemoveAsync(long id);
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> FindAsync(long id);
        Task UpdateAsync(Category cat);
    }
}
