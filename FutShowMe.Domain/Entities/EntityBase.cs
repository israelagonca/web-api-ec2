using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Entities
{
    public abstract class EntityBase<T> : BaseDomainClass<T> where T : class
    {
    }
}
