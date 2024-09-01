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
   public class DepartmentRepositories :GenericRepositories<Department> ,IDepartmentRepositories
    {
        private readonly CompanyDbContext _context;

        public DepartmentRepositories(CompanyDbContext context):base(context)
        {
            _context = context;
        }
        
    }
}
