using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AluguelQuarto {
    internal class Rent {
        public string Name { get; set; }
        public string Email { get; set; }

        public Rent(string name, string email) {
            Name = name;
            Email = email;
        }

        public override string ToString() {
            return Name + ", " + Email;
        }
    }
}
