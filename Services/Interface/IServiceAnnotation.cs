using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;

namespace MakeSense.Services.Interface
{
    interface IServiceAnnotation
    {
        Task AddAsync(Annotation anno);
        Task<int> AddRangeAsync(List<Annotation> anno);
        Task<Annotation> RemoveAsync(long id);
        Task<IEnumerable<Annotation>> GetAllAsync();
        Task<Annotation> FindAsync(long id);
        Task UpdateAsync(Annotation anno);
    }
}
