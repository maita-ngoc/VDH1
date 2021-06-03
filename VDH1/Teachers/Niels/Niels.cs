using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDH1.Teachers.Niels
{
    class Niels
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Niels(string firstName, string lastName) => (firstName, lastName) = (FirstName, LastName);
    }
}
