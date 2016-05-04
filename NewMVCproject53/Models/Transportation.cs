using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace NewMVCproject53.Models
{
    public class Transportation
    {
        [Key]
        public int TransportID { get; set; }
        public string Type { get; set; }

    }
}