using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTypes
{
    public interface IRepository<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
        where TPrimaryKey : struct
    {
        TPrimaryKey Add(TEntity entity);
        T? Get<T>(TPrimaryKey key)
            where T : class, IEntity<TPrimaryKey>;
    }
}
