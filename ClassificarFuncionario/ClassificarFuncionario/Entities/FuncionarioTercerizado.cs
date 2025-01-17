

namespace ClassificarFuncionario.Entities {
    class FuncionarioTercerizado : FuncionarioPadrao {
        private double SalarioAdicional { get; set; }
        public FuncionarioTercerizado(string nome, int hora, double valorPorHora, double salarioAdicional) : base(nome, hora, valorPorHora) {
            SalarioAdicional = salarioAdicional;
        }



        public override double Pagamento() {
            return base.Pagamento() + 1.1 * SalarioAdicional;
        }

    }
}
