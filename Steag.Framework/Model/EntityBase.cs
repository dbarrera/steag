using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steag.Framework.Model
{
    public abstract class EntityBase : IModel, IAuditable
    {
        public Int64 ID { get; protected set; }

        public Int64 UserCreated { get; set; }
        public DateTime DateCreated { get; set; }

        public Int64 UserModified { get; set; }
        public DateTime DateModified { get; set; }
    }
}
