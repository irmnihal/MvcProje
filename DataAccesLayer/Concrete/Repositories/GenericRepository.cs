using DataAccesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
        // bütün repositorylerimi kapsıyacak şekilde olucak
    {
        Context db = new Context();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object=db.Set<T>(); // OBJECT  isimli dışarıdan göderilen değer oldu
        }
        public void Delete(T p)
        {
           _object.Remove(p);
            db.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            db.SaveChanges();
        }

        public List<T> Listele(Expression<Func<T, bool>> Filter)
        {
            return _object.Where(Filter).ToList();
        }

        public List<T> Lİstele()
        {
            return _object.ToList();
        }

        public void Update(T p)
        {
            db.SaveChanges();
        }
    }
}
