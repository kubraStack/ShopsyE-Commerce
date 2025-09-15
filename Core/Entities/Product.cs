using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product : BaseEntity
    {
        /// <summary>
        /// Repsents a product in e-commerce system.
        /// Each product belongs to a single category
        /// </summary>
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }

        // Foreign Key for Category
        public int CategoryId { get; set; }

        //Navigation property for tha relationship
        //This represents  the "one" side of the one-to-many relationship.
        public Category Category { get; set; }

    }
}
