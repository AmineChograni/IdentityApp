using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }
        public string Category { get; set; }


    }
}
