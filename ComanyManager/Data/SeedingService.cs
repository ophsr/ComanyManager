using ComanyManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComanyManager.Data
{
    public class SeedingService
    {
        private ComanyManagerContext _context;

        public SeedingService(ComanyManagerContext salesWebMVCContext)
        {
            _context = salesWebMVCContext;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                    _context.Admin.Any() ||
                    _context.Employee.Any() ||
                    _context.Company.Any() ||
                    _context.Department.Any() ||
                    _context.Profession.Any())
            {
                return; //BD já esta populado
            }
            //Employee e1 = new Employee();
            //_context.Employee.AddRange(e1);
            //_context.SaveChanges();

        }
    }
}
