using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Category : BaseEntity
    {
        /// <summary>
        /// Represents a product category.
        /// A category can have multiple products
        /// </summary>
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
