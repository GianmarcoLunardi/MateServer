using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;
using MakeSense.Services.Interface;

namespace MakeSense.Services
{
    public class ServiceSegmentation : IServiceSegmentation
    {
        private readonly Context BaseDati;
        public ServiceSegmentation(Context _BaseDati)
        {
            BaseDati = _BaseDati;
        }

        public Task AddAsync(Segmentation Seg)
        {
            //BaseDati.Segmentations.AddAsync(Seg);
            //BaseDati.SaveChangesAsync();
            //return Task.CompletedTask;
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<Segmentation> Punti)
        {
            throw new NotImplementedException();
        }

        public Task<Segmentation> FindAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Segmentation>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Segmentation> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Segmentation Punto)
        {
            throw new NotImplementedException();
        }
    }
}
