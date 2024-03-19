using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;
using MakeSense.Services.Interface;

namespace MakeSense.Services
{
    public class ServiceCoordinateB : IServiceCoordinateB
    {
        readonly private Context BaseDati;

        public ServiceCoordinateB(Context _context )
        {
            BaseDati = _context;
        }

        public async Task<int> Add(CoordinateB Point)
        {
            await BaseDati.CoordinateBs.AddAsync(Point);
            return await BaseDati.SaveChangesAsync();
          //  throw new NotImplementedException();
        }

        public async Task<int> AddRangeAsync(List<CoordinateB> ListaPunti)
        {
            await BaseDati.CoordinateBs.AddRangeAsync(ListaPunti);
            return await BaseDati.SaveChangesAsync();
        }

        public Task<CoordinateB> FindAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CoordinateB>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CoordinateB> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CoordinateB Punto)
        {
            throw new NotImplementedException();
        }
    }
}
