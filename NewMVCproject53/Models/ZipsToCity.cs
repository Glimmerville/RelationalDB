using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewMVCproject53.Models
{
    public class ZipsToCity
    {
        [Key]
        public int ZipsToCityId { get; set; }

        //foreign key for Zipcode
        public int ZipCodeId { get; set; }
        public Zipcode Zippitycode { get; set; }

        //Foreign key for Cities
        public int CityId { get; set; }
        public Cities Citycode { get; set; }
    }
}