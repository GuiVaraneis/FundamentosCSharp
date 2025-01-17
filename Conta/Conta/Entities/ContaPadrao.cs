

using System.Text;

namespace Conta.Entities {
     class ContaPadrao {
        public int Numero { get; set; }
        public string Titular { get; set;}
        
        public double Saldo { get; protected set;}



        public ContaPadrao() { }

        public ContaPadrao(int numero, string titular, double saldo) {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public virtual void Saque(double quantia) {
            Saldo -= quantia - 5.00;
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Número da conta: {Numero}");
            sb.AppendLine($"Titular da conta: {Titular}");
            sb.AppendLine($"Saldo da conta: {Saldo}");
            return sb.ToString();
        }

    }
}
