using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAngularAPI.Models
{
    public class Client 
    {
        [Key]
        public int Clients_key { get; set; }
        public string FullName { get; set; }
        public string DocumentType { get; set; }        
        public string ID { get; set; }
        public string Cellphone { get; set; }
        public string Address { get; set; }
        public string email { get; set; }
    }
}