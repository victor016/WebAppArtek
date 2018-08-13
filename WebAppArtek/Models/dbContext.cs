﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebAppArtek.Models
{
    public class dbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public dbContext() : base("name=dbContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        public System.Data.Entity.DbSet<WebAppArtek.Models.Materiales> MaterialesModels { get; set; }

        public System.Data.Entity.DbSet<WebAppArtek.Models.ClienteExterno> ClienteExternoes { get; set; }

        public System.Data.Entity.DbSet<WebAppArtek.Models.Contacto> Contactoes { get; set; }
    }
}
