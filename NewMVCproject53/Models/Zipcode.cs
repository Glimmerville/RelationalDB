using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewMVCproject53.Models
{
    public class Zipcode
    {
        [Key]
        public int ZipCodeId { get; set; }

        //do I need this? yes
        public string ZipCodeValue { get; set; }

    }
}