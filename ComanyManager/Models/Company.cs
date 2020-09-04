using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComanyManager.Models
{
    public class Company
    {
        public int Id { get; private set; }
        public string NameCompany { get; private set; }
        public string URL { get; private set; }
        public List<Employee> CompanyEmployee { get; private set; }
        public List<Admin> CompanyAdmin { get; private set; }
        public List<Department> DepartmentsList { get; private set; }
        public List<Profession> ProfessionsList { get; private set; }




    }
}
