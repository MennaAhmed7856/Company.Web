using Company.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repostory.Interfaces
{
    public interface IGenericRepositories<T> where T : BaseEntity
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T employee);
        void Update(T employee);
        void Delete(T employee);
    }
}
    

