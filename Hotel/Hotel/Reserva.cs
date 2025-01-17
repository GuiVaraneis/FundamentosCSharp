using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Hotel {
    internal class Reserva {
        public string Nome { get; set; }
        public string Email { get; set; }

        public int NumQuarto { get; set; }

        public Reserva(string nome, String email, int numQuarto ) {
            Nome = nome;
            Email = email;
            NumQuarto = numQuarto;
        }
        public override string ToString() {
            return Nome + ", " + Email;  
        }
    }
}
