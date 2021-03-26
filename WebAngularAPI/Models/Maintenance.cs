using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAngularAPI.Models
{
    public class Maintenance
    {
        public int Maintenance_key { get; set; }
        public int Clients_key { get; set; }
        public string Description { get; set; }
        public DateTime initialDate { get; set; }        
        public DateTime endDate { get; set; }
        public bool State { get; set; }      
    }
}