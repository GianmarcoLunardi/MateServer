using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;

namespace MakeSense.Services.Interface
{
    public interface IServiceCoordinateB
    {
        Task<int> Add(CoordinateB Point);
        Task<int> AddRangeAsync(List<CoordinateB> ListaPunti);
        Task<CoordinateB> RemoveAsync(long id);
        Task<IEnumerable<CoordinateB>> GetAllAsync();
        Task<CoordinateB> FindAsync(long id);
        Task UpdateAsync(CoordinateB Punto);
    }
}
