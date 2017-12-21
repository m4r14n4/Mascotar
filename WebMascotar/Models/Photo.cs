using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMascotar.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string Name { get; set; }

        public virtual Pet Pet { get; set; }

    }
}