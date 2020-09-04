using System;

namespace ComanyManager.Models.Interfaces
{
    public interface IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int CEP { get; set; }
        public int AddressNumber { get; set; }
        public string Complement { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
        public Profession Profession { get; set; } 
        public Department Department { get; set; }


    }
}
