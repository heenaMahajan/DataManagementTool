using DataManagementTool.Data;
using System.Collections.Generic;
using System.Linq;

namespace DataManagementTool.Repo
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IEnumerable<T> GetAll(params string[] include);
        T Get(long id);
        T Get(long id, params string[] include);
        void Insert(T entity);
        void Insert(IEnumerable<T> entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
        IQueryable<T> RunStoredProcedure(string commandName, string[] parameteres);

        IQueryable<T> RunSpInsertContactUsingXml(string commandName, string xml);
        void SaveChanges();
    }
}
