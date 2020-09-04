using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComanyManager.Models.Interfaces;


namespace ComanyManager.Models
{
    public class Admin : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int CEP { get; set; }
        public int AddressNumber { get; set; }
        public string Complement { get; set; }
        public Company Company { get; set; }
        public Profession Profession { get; set; } = null;
        public Department Department { get; set; } = null;

    }
}
