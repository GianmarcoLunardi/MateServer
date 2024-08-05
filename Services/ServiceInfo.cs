using MakeSense.Models;
using MakeSense.Services.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Services
{
    public class ServiceInfo : IServiceInfo
    {
        static int contatore;
        private readonly Context BaseDati;



        public async Task UploadJson(IFormFile file)
        {
            Console.WriteLine("Siamo dentro l inseriemento dell upload json");
            Console.WriteLine(file.FileName);

            contatore++;

            string path = Path.Combine(Directory.GetCurrentDirectory(), "CocoDirectory", "coco" + contatore + ".json");

            Console.WriteLine(path);

            using (FileStream stram = new FileStream(path, FileMode.Create))
            { file.CopyTo(stram); }

            // il file prima di essere utilizzato va salavato su una directory poi va riaperto

            // string StringaFile = File.ReadAllText(@"C:\Users\Gianmarco\Documents\C\MakeSense\CocoDirectory\coco1.json");
            Console.WriteLine(path);
            string StringaFile = File.ReadAllText(path);
            // string StringaFile = File.ReadAllText(file.FileName);

            // Console.WriteLine(path);
            /*
           
            string[] linee = File.ReadAllLines(path);
            
                       foreach( string lineaJson in linee)
                       { Console.WriteLine(lineaJson);  }
            */

            Console.WriteLine(StringaFile);
        }
    }
}
