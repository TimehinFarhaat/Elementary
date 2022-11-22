using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationUser.Contracts
{
    public class AuditableEntity : BaseEntity, ISoftDelete, IAuditableEntity
    {
        public int CreatedBy { get; set; }


        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;


        public int LastModifiedBy { get; set; }


        public DateTime? LastModifiedOn { get; set; } = DateTime.UtcNow;

        public DateTime? DeletedOn { get; set; }

        public int? DeletedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}
