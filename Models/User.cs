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
    [Table("user")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public int Prog { get; set; }
        
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string city { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public DateTime Submitted { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Role Role { get; set; }
        public DateTime ApprovedOn { get; set; }

        // Attenzione può generare un riferimento circolare
        //public User ApprovedBy { get; set; }



    }
}
