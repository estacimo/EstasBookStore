using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EstasBookStore.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id); // Retrieve a category from the database by id
        // List of categories based on requirements
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null // Useful for foreign key refs
            );
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );
        void Add(T entity); // To Add an entity
        void Remove(int id); // To remove an object/category
        void Remove(T entity); // Other way to remove an object
        void RemoveRange(IEnumerable<T> entity); // To remove a complete range of entities
    }
}
