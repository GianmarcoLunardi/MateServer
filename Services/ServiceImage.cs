using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;

namespace MakeSense.Services
{
    public class ServiceImage
    {
        private readonly Context BaseDati;

        public ServiceImage(Context baseDati)
        {
            BaseDati = baseDati;
        }
    }
}
