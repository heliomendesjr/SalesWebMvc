using SalesWebMvc1.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc1.Models;

namespace SalesWebMvc1.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc1Context _context;
        public DepartmentService(SalesWebMvc1Context context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
