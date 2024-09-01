using Company.Data.Contexts;
using Company.Data.Entities;
using Company.Repostory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repostory.Repositories
{
    public class GenericRepositories<T> : IGenericRepositories<T> where T : BaseEntity
    { 
    private readonly CompanyDbContext _context;
    
        public GenericRepositories(CompanyDbContext context) {
        _context = context;

        }
        public void Add(T entity)
        { 
       _context.Set<T>().Add(entity);
       _context.SaveChanges();
}
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
       => _context.Set<T>().ToList();

        public T GetById(int id)
        => _context.Set<T>().Find(id);

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
