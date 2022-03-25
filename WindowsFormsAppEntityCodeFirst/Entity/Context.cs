using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppEntityCodeFirst.Entity
{
    public class Context:DbContext
    {
        public DbSet<Products> Products { get; set; }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Customers> Customers { get; set; }

    }
}
