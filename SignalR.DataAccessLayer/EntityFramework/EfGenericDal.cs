using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.EntityFramework
{

    public class EfGenericDal<T> : IGenericDal<T> where T : class
    {
        private readonly SignalRContext _context;
        public EfGenericDal(SignalRContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);//Hali hazırda entity'miz belli olduğu için Set kullanmamıza gerek yok
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);//id'nin hangi entity nesnesinde oldugunu belirtmek için Set ile entity'yi belirtmemiz lazım.
        }

        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
