using ReservaHotel.Entities;

class Program {
    static void Main(string[] args) {
        Console.Write("Numero do quarto: ");
        int numeroQuarto = int.Parse(Console.ReadLine());
        Console.Write("Check-in(dd/mm/yyyy): ");
        DateTime checkIn = DateTime.Parse(Console.ReadLine());
        Console.Write("Check-out(dd/mm/yyyy): ");
        DateTime checkOut = DateTime.Parse(Console.ReadLine());

        if (checkOut <= checkIn) {
            Console.WriteLine("Erro!!! data do Check-Out é menor que a data do Check-In");
        }
        else {
            Reserva reserva = new Reserva(numeroQuarto, checkIn, checkOut);
            Console.WriteLine("Reserva: " + reserva);
        }
    }




}



