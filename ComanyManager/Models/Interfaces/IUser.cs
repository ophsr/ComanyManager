using System;

namespace ComanyManager.Models.Interfaces
{
    interface IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int CEP { get; set; }
        public int AddressNumber { get; set; }
        public string Complement { get; set; }


    }
}
