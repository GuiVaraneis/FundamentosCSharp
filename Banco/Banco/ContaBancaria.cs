
using System.Globalization;

namespace Banco {
    class ContaBancaria {
        public int NumeroDaConta { get; private set; }
        public string Titular {  get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string titular, int numeroDaConta, double depositoInicial) : this(titular, numeroDaConta) {
            Depositar(depositoInicial);
        }
        public ContaBancaria(string titular, int numeroDaConta) {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
            
        }

      

        public bool VerificaInformacoesDoUsuario(string nome, int numeroDaConta) {
            if ((nome != null && nome.Length > 1) && (numeroDaConta != 0 && numeroDaConta.ToString().Length == 3)) {
                return true;
            }
            else {
                return false;
            }
            
        }

        public double Depositar (double valorDepositado) {
            return Saldo += valorDepositado;
        }

        public double Sacar(double valorSacado) {
            return Saldo = (Saldo - valorSacado) - 3.00;
        }


        public override string ToString() {
            return "\nTitular: " + Titular +
                    "\nNúmero da conta: " + NumeroDaConta +
                    "\nValor Depositado: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
