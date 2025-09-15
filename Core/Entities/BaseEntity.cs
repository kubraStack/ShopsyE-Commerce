using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class BaseEntity
    {
        /// <summary>
        /// * Represents the base class for all entities in the system.
        /// * Provides common properties like Id, CreatdDate, DeletedDate and UpdatedDate.
        /// * This is an abstract class, so it cannot be instantiated directly.
        /// </summary>
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
