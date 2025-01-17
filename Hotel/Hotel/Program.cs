
using Hotel;
using System.Reflection.Metadata.Ecma335;

class Program {
	static void Main(string[] args) {


		Reserva[] vect = new Reserva[10];

		Console.Write("Informe quantidade de quartos: ");
		int qtdQuartos = int.Parse(Console.ReadLine());
		if(qtdQuartos < 1 || qtdQuartos > 10) {		
            Console.WriteLine("Falha na operação: Fora do limite da quantidade de quartos");
        }
		for (int i = 0; i < qtdQuartos; i++) {
            Console.WriteLine("Numero do quarto: ");
            int numeroDoQuarto = int.Parse(Console.ReadLine());

			if (vect[numeroDoQuarto-1] == null) {
                Console.WriteLine("Nome do ocupante");
                string? nome = Console.ReadLine();

                Console.WriteLine("Email do Ocupante: ");
                string? email = Console.ReadLine();

				vect[numeroDoQuarto - 1] = new Reserva(nome, email, numeroDoQuarto);
				
			}
			else {
				Console.WriteLine("Este quarto já está ocupado.");
				
			}
			

		}
        for (int i = 0;i < vect.Length-1;i++) { 
			if (vect[i] == null) {
				Console.WriteLine($"Quarto {i+1}: Vago!!!");
			}
			else {
				Console.WriteLine($"Quarto {i + 1}:{vect[i]}  ");
			}
		
		}
    }
}


