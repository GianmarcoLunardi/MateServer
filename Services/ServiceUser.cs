using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;
using MakeSense.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MakeSense.Services
{
    public class ServiceUser : IServiceUtente
    {
        private readonly Context BaseDati;

        public ServiceUser(Context baseDati)
        {
            BaseDati = baseDati;
        }

        public IList<GuidName> menu()
        {
            IList<GuidName> lista = new List<GuidName>();

            //Console.WriteLine(lista.Count());

            foreach (User x in BaseDati.Users)
            {
                lista.Add(new GuidName(x.Id.ToString("D"), x.LastName + " " + x.FirstName));
            }

            return lista;

        }



        public void Add(User entity)
        {

            entity.Id =  new Guid() ;
             BaseDati.Users.Add(entity);
             BaseDati.SaveChanges();
          //  throw new NotImplementedException();
        }

        public async Task<User[]> ListAsyn()
        {
           return await BaseDati.Users.ToArrayAsync<User>();
            
            
        }

        public List<User> ListUser()
        {
            return BaseDati.Users.ToList<User>();
        }


        User IServiceUtente.Find(Guid id)
        {
            return BaseDati.Users.Find(id);
        }
    }
}


