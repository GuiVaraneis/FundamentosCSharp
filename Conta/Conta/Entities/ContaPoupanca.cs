

namespace Conta.Entities {
     class ContaPoupanca : ContaPadrao {

        public double TaxaJuros { get; set; }

        public ContaPoupanca() { }

        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) 
            :base(numero, titular, saldo){
            TaxaJuros = taxaJuros;
        }

        public void AtualizarSaldo() {
            Saldo = Saldo * TaxaJuros;
        }

        public override string ToString() {
            return base.ToString() + $"Taxa de juros: {TaxaJuros}";
        }

        public override void Saque(double quantia) { 
            base.Deposito(quantia);
            Saldo -= 2;   
        }
    }
}
