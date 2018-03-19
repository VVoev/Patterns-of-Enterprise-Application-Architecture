using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RepositoryDemo
{
    class Startup
    {
        static void Main(string[] args)
        {
        }
    }

    public class Student
    {
        public string Name { get; set; }
    }

    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }

    public class Repository<T> : IRepository<T> where T : class
    {
        //private readonly DbContext context;

        //public Repository(DbContext context)
        //{
        //    this.context = Contextcontext;
        //}
        public void Add(T entity)
        {
            //return Context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
