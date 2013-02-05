using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;

namespace Domain.BooksFlowers
{
    public class Supplier
    {
        [Key]
        public string SupplierCode { get; set; }

        [MinLength(5)]
        [MaxLength(20)]
        public string Name { get; set; }
       // public int NewCol { get; set; }
    }
}
