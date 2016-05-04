using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewMVCproject53.Models
{
    public class Sales
    {
        [Key]
        public int SalesId { get; set; }

        //foreign key for Customer 
        public int CustomerId { get; set; }
        public Customers Customer { get; set; }

        //Foreign key for PropertyModels
        public int PropertyId { get; set; }
        public PropertyModel Property { get; set; }
        
        public decimal SalesPrice { get; set; }
        public DateTime SalesDate { get; set; }

        //this is now joined!
    }
}