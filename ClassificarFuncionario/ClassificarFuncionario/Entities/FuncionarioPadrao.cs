

namespace ClassificarFuncionario.Entities {
     class FuncionarioPadrao {
        public string Nome { get; set; }

        private int Hora { get; set; }

        private double ValorPorHora { get; set; }

        public FuncionarioPadrao(string nome, int hora, double valorPorHora) {
            Nome = nome;
            Hora = hora;
            ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento() {
            return Hora * ValorPorHora;
        }
    }
}
