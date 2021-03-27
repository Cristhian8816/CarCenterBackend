using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAngularAPI.Models
{
    public class Maintenance
    {
        [Key]
        public int Maintenance_key { get; set; }
        [ForeignKey("Clients")]
        public int Clients_key { get; set; }
        public string Description { get; set; }
        public DateTime initialDate { get; set; }        
        public DateTime endDate { get; set; }
        public bool State { get; set; }      
    }
}