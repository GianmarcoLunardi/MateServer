using MakeSense.Models;
using MakeSense.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Services
{
    public class ServiceAnnotation : IServiceAnnotation
    {
        private readonly Context BaseDati ;
        public ServiceAnnotation(Context _BaseDati)
        {
            BaseDati = _BaseDati;
        }

        public Task AddAsync(Annotation anno)
        {
            BaseDati.Annotations.AddAsync(anno);
            BaseDati.SaveChangesAsync();
            return Task.CompletedTask;
            //throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<Annotation> anno)
        {
            throw new NotImplementedException();
        }

        public Task<Annotation> FindAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Annotation>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Segmentation> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Annotation anno)
        {
            throw new NotImplementedException();
        }
    }
}
