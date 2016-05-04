using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewMVCproject53.Models
{
       public partial class Zip2Cities
    {
        [Key]
        public int Zip2CitiesId { get; set; }

        //foreign key to Cities
        public int CityId { get; set; }
        public Cities City { get; set; }

        // foreign key to ZipCode
        public int ZipCodeId { get; set; }
        public Zipcode Zipcode { get; set; }

    }
}