using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public Company Company { get; set; } = null;
        public int CompanyId { get; set; }
        public Profession Profession { get; set; } = null;
        public Department Department { get; set; } = null;

        public Employee()
        {
        }

        public Employee(int id, string name, DateTime birthDate, int cEP, int addressNumber, string complement, Company company, int companyId)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            CEP = cEP;
            AddressNumber = addressNumber;
            Complement = complement;
            Company = company;
            CompanyId = companyId;

        }
    }
}
