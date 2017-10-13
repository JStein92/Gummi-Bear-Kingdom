using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GummiBearKingdom.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCost { get; set; }
        public string ProductCountry { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
