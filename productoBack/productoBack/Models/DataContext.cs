﻿

namespace productoBack.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {


        }

        public System.Data.Entity.DbSet<productoBack.Models.product> products { get; set; }
    }
}