using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Services.Interface
{
    public interface IServiceInfo
    {
        public Task UploadJson(IFormFile file);

    }
}
