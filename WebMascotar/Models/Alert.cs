using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMascotar.Models
{
    public class Alert
    {
        public int ID { get; set; }
        public int IdUser { get; set; }
        public int IdPet { get; set; }
        public int IdPhoto { get; set; }
        public byte[] Image { get; set; }

    }
}