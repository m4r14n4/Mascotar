using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMascotar.Models
{
    public class User
    {
        public int ID { get; set; }        
        public string Mail { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public int Zone { get; set; }
        public int Pet1 { get; set; }
        public int Pet2 { get; set; }
        public int Pet3 { get; set; }


        public virtual Zone Zones { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }

    }
}