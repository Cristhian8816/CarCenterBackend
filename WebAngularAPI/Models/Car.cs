using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAngularAPI.Models
{
    public class Car
    {
        [Key]
        public int Car_key { get; set; }
        [ForeignKey("Clients")]
        public int Clients_key { get; set; }
        public string Marca { get; set; }
        
    }
}