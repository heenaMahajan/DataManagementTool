using Microsoft.EntityFrameworkCore;
using DataManagementTool.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace DataManagementTool.Repo
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public IQueryable<T> GetAll()
        {
            return entities.AsQueryable();
        }
        public IEnumerable<T> GetAll(params string[] include)
        {
            IQueryable<T> query = context.Set<T>();
            foreach (string inc in include)
            {
                query = query.Include(inc);
            }
            return query;
        }

        public T Get(long id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }
        public T Get(long id, params string[] include)
        {
            IQueryable<T> query = context.Set<T>();
            foreach (string inc in include)
            {
                query = query.Include(inc);
            }

            return query.SingleOrDefault(s => s.Id == id);
        }
        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }
        public void Insert(IEnumerable<T> entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.AddRange(entity);
            context.SaveChanges();
        }
        public IQueryable<T> RunStoredProcedure(string commandName, string[] parameteres)
        {
            try
            {
                //context.Database.ExecuteSqlCommand(commandName, new SqlParameter("name", "Realy Big Train"),
                //          new SqlParameter("traintype", "AT1"));
                // return context.Set<T>().FromSql(commandName);
                //return context.Set<T>().FromSql(commandName);
                //  return context.Database.SqlQuery<TEntity>(commandName, parameteres);
                // return context.Set<T>()
                //.FromSql("GetContacts @p0, @p1",
                //      parameters: new[] { "g", Convert.ToString(330) });
                return context.Set<T>()
               .FromSql(commandName,
                     parameters: parameteres);
                //return context.Set<T>().FromSql(commandName,parameteres);

            }
            catch (Exception ex)
            {

                throw;
            }
        }


        /// <summary>
        /// Runs the store procedure of insert contact using XML file.
        /// </summary>
        /// <param name="commandName">Name of the command.</param>
        /// <param name="xml">The XML.</param>
        /// <returns></returns>
        public IQueryable<T> RunSpInsertContactUsingXml(string commandName, string xml)
        {
            try
            {
                 context.Database.SetCommandTimeout(1200);
                 context.Database.ExecuteSqlCommand("InsertContactTempsUsingXml @p0", xml);
                 return context.Set<T>().FromSql(commandName);
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.RemoveRange(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        
    }
}
