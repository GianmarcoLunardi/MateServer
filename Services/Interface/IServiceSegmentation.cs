using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;

namespace MakeSense.Services.Interface
{
    public interface IServiceSegmentation
    {
        Task AddAsync(Segmentation Seg);
        Task AddRangeAsync(IEnumerable<Segmentation> Punti);
        Task<Segmentation> RemoveAsync(long id);
        Task<IEnumerable<Segmentation>> GetAllAsync();
        Task<Segmentation> FindAsync(long id);
        Task UpdateAsync(Segmentation Punto);
    }
}
