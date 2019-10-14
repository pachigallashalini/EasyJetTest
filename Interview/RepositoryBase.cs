using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class RepositoryBase<T, I> : IRepository<T, I> where T : IStoreable<I>
    {
        private IList<T> entities = new List<T>();
        public void Delete(I id)
        {
            var entityToRemove = entities.FirstOrDefault(i => i.Id.Equals(id));
            if (entityToRemove != null)
            {
                entities.Remove(entityToRemove);
            }
        }

        public T Get(I id)
        {
            return entities.FirstOrDefault(i => i.Id.Equals(id));
        }

        public IEnumerable<T> GetAll()
        {
            return entities;
        }

        public void Save(T item)
        {
            entities.Add(item);
        }
    }
}
