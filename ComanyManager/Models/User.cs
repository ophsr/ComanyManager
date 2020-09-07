using System;

namespace ComanyManager.Models
{
    public class User
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

        public User(int id, string name, DateTime birthDate, int cEP, int addressNumber, string complement, Company company)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            CEP = cEP;
            AddressNumber = addressNumber;
            Complement = complement;
            Company = company;
            CompanyId = Company.Id;
            Profession = null;
            Department = null;
        }
        public User()
        {

        }
    }
}
