

namespace ProductoApi.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext(): base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<ProductoApi.Models.product> products { get; set; }
    }
}