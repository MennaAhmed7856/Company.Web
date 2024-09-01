using Company.Repostory.Interfaces;
using Company.Repostory.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Company.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepositories _departmentRepositories;

        public DepartmentController(IDepartmentRepositories departmentRepositories)
        {
            _departmentRepositories = departmentRepositories;
        }

        public IActionResult Index()
        {
            var departments = _departmentRepositories.GetAll();
            return View(departments);
        }
    }
}
