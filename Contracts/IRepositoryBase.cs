using System.Collections.Generic;

namespace leave_management.Contracts
{
    public interface IRepositoryBase<T> where T : class // I should be able to pass any class
    {
        // Every class should implement CRUD operations
        ICollection<T> FindAll(); // Returning all (select * from table)

        T FindById(int id);

        bool Create(T entity); // Create some entity of type T (generic)

        bool Update(T entity);

        bool Delete(T entity);

        bool Save();
    }
}