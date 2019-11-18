using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Entities
{
    public abstract class BaseDomainClass<T> : IAggregateRoot where T : class
    {
        public virtual void Validate()
        {
        }
    }
}
