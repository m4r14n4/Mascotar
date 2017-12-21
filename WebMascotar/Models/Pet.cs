using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMascotar.Models
{
    public class Pet
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mark1 { get; set; }
        public string Mark2 { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }

    }
}