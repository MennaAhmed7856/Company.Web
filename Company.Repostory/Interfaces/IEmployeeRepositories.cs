using Company.Data.Entities;

namespace Company.Repostory.Interfaces
{
    public interface IEmployeeRepositories:IGenericRepositories<Employee>
    {
      Employee GetEmployee(string name );

    }
}
