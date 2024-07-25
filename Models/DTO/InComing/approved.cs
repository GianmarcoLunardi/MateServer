using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models.DTO.InComing
{

    // Calsse Per lo scambio dati 
    //
    //nella pagina 


    public class approved
    {
        // Da Chi viene approvato
        public Guid IdUser { get; set; }
        public Guid IdFoto { get; set; } 
    }
}
