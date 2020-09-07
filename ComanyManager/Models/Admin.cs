using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ComanyManager.Models
{
    public class Admin : User
    {
        public Admin(int id, string name, DateTime birthDate, int cEP, int addressNumber, string complement, Company company)
            : base(id, name, birthDate, cEP, addressNumber, complement, company)
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
        public Admin()
        {

        }

    }
}
