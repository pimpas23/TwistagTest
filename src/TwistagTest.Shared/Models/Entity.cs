using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwistagTest.Shared.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
        }

        public Guid Id { get; set; }
    }
}
