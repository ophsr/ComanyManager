﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComanyManager.Models
{
    public class Profession
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; private set; }

        public Profession(int id, int name)
        {
            Id = id;
            Name = name;
        }
    }
}
