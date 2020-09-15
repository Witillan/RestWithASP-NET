using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNET.Model
{
    public class Person
    {
        public long Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Address { get; }
        public string Gender { get; }
    }
}
