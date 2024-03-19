using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;

namespace MakeSense.Services.Interface
{
    public interface IServiceCoordinate
    {
        Task Add(Coordinate Point);
        Task AddRangeAsync(List<Coordinate> Punti);
        Task<Coordinate> RemoveAsync(long id);
        Task<IEnumerable<Coordinate>> GetAllAsync();
        Task<Coordinate> FindAsync(long id);
        Task UpdateAsync(Coordinate Punto);
    }
}

/*
 * Task AddRangeAsync(IEnumerable<BookChapter> chapters);
Task<BookChapter> RemoveAsync(Guid id);
Task<IEnumerable<BookChapter>> GetAllAsync();
Task<BookChapter> FindAsync(Guid id);
Task UpdateAsync(BookChapter chapter);
 * 
 * 
 * 
*/