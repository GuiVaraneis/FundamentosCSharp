
namespace Loja.Entities {
    class Cliente {
        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime Nascimento { get; set; }

        public Cliente() { }
        public Cliente(string nome, string email, DateTime aniversario) {
            Nome = nome;
            Email = email;
            Nascimento = aniversario;

        }

        public override string ToString() {
            return  "\nNome: " + Nome +
                    "\nE-mail: " + Email +
                    "\nData de nascimento: " + Nascimento.ToString("dd/MM/yyyy");
        }

    }
}
