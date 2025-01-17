
namespace Conta.Entities {
     class ContaEmpresarial : ContaPadrao {
        public double EmprestimoLimite { get; set; }

        public ContaEmpresarial() { }
            
        public ContaEmpresarial(int numero, string titular, double saldo, double emprestimoLimite) 
            : base(numero, titular, saldo) {

            EmprestimoLimite = emprestimoLimite;
        }

        public void Emprestimo(double quantia) {
            if (quantia <= EmprestimoLimite) {
                Saldo += quantia;
            }
        }
        public override string ToString() {
            return base.ToString() + $"Limite de Emprestimo: {EmprestimoLimite}";
        }
    }
        
}
