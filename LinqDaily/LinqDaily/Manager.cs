using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDaily
{
    public class Manager
    {
        public Manager()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public Guid? ParentId { get; set; }

        public string Name { get; set; }
    }
}
