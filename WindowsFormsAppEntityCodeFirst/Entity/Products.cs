using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppEntityCodeFirst.Entity
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductMarka { get; set; }
        public string ProductCategory { get; set; }
        public int ProductStok { get; set; }
    }
}
