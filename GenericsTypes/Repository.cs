using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTypes
{
    public class Repository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
        where TPrimaryKey : struct
    {
        private readonly Dictionary<string, List<TEntity>> _colection = new();
        public TPrimaryKey Add(TEntity entity)
        {
           var type = entity.GetType();
            var containsList = _colection.TryGetValue(type.Name, out var list);

            if (!containsList) 
            {
                list = new List<TEntity>();
                entity.Id = GetNextId(list);
                list.Add(entity);
                _colection.Add(type.Name, list);
                return entity.Id;
            }

            entity.Id = GetNextId(list);
            list.Add(entity);
            return entity.Id;
        }

        public T? Get<T>(TPrimaryKey key)
            where T : class, IEntity<TPrimaryKey>
        {
            var type = typeof(T);
            var containsList = _colection.TryGetValue(type.Name, out var list);
            if (!containsList)
            {
                return null;
            }

            foreach (var entities in list)
            {
                if (entities.Equals(key))
                {
                    return entities as T;
                }
            }
            return null;
        }

        private TPrimaryKey GetNextId(List<TEntity> entities) 
        {
            if (entities.Count == 0) 
            {
                return GetNextValue(default);
            }
            return GetNextValue(entities[entities.Count - 1].Id);
        }

        private TPrimaryKey GetNextValue(TPrimaryKey key) 
        {
            var type = key.GetType();

            if(type == typeof(int))
            {
                object value = key;
                object nextValue = ((int)value) + 1;
                return (TPrimaryKey)nextValue;
            }
            if (type == typeof(long))
            {
                object value = key;
                object nextValue = ((long)value) + 1;
                return (TPrimaryKey)nextValue;
            }
            if (type == typeof(Guid)) // globalny identyfikator
            {
                object nextValue = Guid.NewGuid();
                return (TPrimaryKey)nextValue;
            }
            else
            {
                return default;
            }

        }
    }
}
