using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMascotar.Models
{
    public class Zone
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public virtual ICollection<User> Users { get; set; }

    }
}