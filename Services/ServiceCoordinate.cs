using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;
using MakeSense.Services.Interface;

namespace MakeSense.Services
{
    public class ServiceCoordinate : IServiceCoordinate
    {
        private readonly Context BaseDati;

        public ServiceCoordinate(Context baseDati)
        {
            BaseDati = baseDati;
        }

        // Aggiunta di una riga nella tabella coordinate

        public async  Task Add(Coordinate Point)
        {
           // await  BaseDati.Coordinates.AddAsync(Point);
           // await  BaseDati.SaveChangesAsync();
           // return null;//Task.CompletedTask;
           throw new NotImplementedException();
        }

        public async Task AddRangeAsync(List<Coordinate> Punti)
        {

           // await BaseDati.Coordinates.AddRangeAsync(Punti);
           // await BaseDati.SaveChangesAsync();
           // return Task.CompletedTask;

             throw new NotImplementedException();

        }

        public Task<Coordinate> FindAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Coordinate>> GetAllAsync()
        {
           // return await BaseDati.Coordinates;
            throw new NotImplementedException();
        }

        public Task<Coordinate> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Coordinate Punto)
        {
            throw new NotImplementedException();
        }
    }
}



