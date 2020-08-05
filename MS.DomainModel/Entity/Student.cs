using System;
using System.Collections.Generic;
using System.Text;

namespace MS.DomainModel.Entity
{
    public class Student: BaseEntity, IEntityId<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
