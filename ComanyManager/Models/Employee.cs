using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComanyManager.Models.Interfaces;

namespace ComanyManager.Models
{
    public class Employee : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int CEP { get; set; }
        public int AddressNumber { get; set; }
        public string Complement { get; set; }
        public Company Company { get; private set; }

        public Profession Profession { get; private set; }
        public Department Department { get; private set; }





    }
}
