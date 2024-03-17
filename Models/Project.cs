using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models
{
    [Table("Project")]
    public class Project
    {
        [Key]
        [Column("Id")]
        public long Id { get; set; }

        [Column("Name")]
        [MaxLength(500)]
        [MinLength(1)]
        public string Name { get; set; }

        [Column("Data")]
        public DateTime Data { get; set; }

    }
}

/*
 * Creazione Della taballa Progetti, che raccoglie tutti i porogetti da archiaviare 
 * Il campo id è chiave primari , presa con id long, a chiave primaria tipo longint
 * Una volta fatta la tabella 
 * poi tutto il mappping 
 */