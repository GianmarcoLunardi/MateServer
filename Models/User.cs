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
        public long Id_User { get; set; }
        [Column("User Mail")]
        public string UserMail { get; set; }
        [Column("User Name")]
        public string UserName { get; set; }
        [Column ("Registtration Date")]
        public DateTime Registtration_Date { get; set; }
        public string Surname { get; set; }
        public  string Name { get; set; }
        [Column("City of Residence")]
        public String City_of_Residence { get; set;}
        public  DateTime Date_Of_Beartg { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        [Column("University Work")]
        public string University_Work { get; set; }
        


    }
}
