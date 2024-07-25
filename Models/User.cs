using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;



/*
 * Il Login Avvine tramite 
 * Il Loghin Avvine 
*   UserMail e Password
 * 
 */
namespace MakeSense.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string city { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public DateTime SubmittedDate { get; set; }
        public string JobSection { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        
        public DateTime ApprovedOn { get; set; }

        public ICollection<Image> ImagesAproved { get; } = new List<Image>();



        // Attenzione può generare un riferimento circolare

        public List<User> ApprovedBy { get; set; }
        
        List<Registry> registries { get; set; }

    }
}
