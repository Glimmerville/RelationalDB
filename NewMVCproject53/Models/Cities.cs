using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewMVCproject53.Models
{
    public class Cities
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string ImgSrc { get; set; }
        public string Description { get; set; }
        public decimal Lat { get; set; }
        public decimal Long { get; set; }

        //Foreign Key for State
        public int StateId { get; set; }
        public State Sta { get; set; }

    }
}