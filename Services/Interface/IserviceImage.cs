using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;

namespace MakeSense.Services.Interface
{
    public interface IserviceImage
    {
        Task Add(Image immagine);
    }
}
