using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;
using MakeSense.Services.Interface;

namespace MakeSense.Services
{
    public class ServiceCategory : IServiceCategory
    {
        readonly private Context BaseDati;
        public ServiceCategory(Context _BaseDati)
        {
            BaseDati = _BaseDati;
        }

        public Task AddAsync(Category cat)
        {
            BaseDati.Categories.AddAsync(cat);
            BaseDati.SaveChangesAsync();
            return Task.CompletedTask;
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<Category> Cat)
        {
            throw new NotImplementedException();
        }

        public Task<Category> FindAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Category cat)
        {
            throw new NotImplementedException();
        }
    }
}
