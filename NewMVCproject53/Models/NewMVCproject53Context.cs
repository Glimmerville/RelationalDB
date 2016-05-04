using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewMVCproject53.Models
{
    public class NewMVCproject53Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public NewMVCproject53Context() : base("name=NewMVCproject53Context")
        {
        }

        
        public System.Data.Entity.DbSet<NewMVCproject53.Models.PropertyModel> PropertyModels { get; set; }
        public System.Data.Entity.DbSet<NewMVCproject53.Models.Customers> Customers {  get; set; }

        public System.Data.Entity.DbSet<NewMVCproject53.Models.Cities> Cities { get; set; }

        public System.Data.Entity.DbSet<NewMVCproject53.Models.Sales> Sales { get; set; }
    }
}
