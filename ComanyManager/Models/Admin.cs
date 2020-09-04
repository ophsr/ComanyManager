using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComanyManager.Models
{
    public class Admin : Employee
    {
        public new Company Company { get; private set; }

    }
}
