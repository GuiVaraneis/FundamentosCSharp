using ReservaHotel.Entities;
using ReservaHotel.Entities.Exceptions;

class Program {
    static void Main(string[] args) {
        try { 
            Console.Write("Numero do quarto: ");
            int numeroQuarto = int.Parse(Console.ReadLine());
            Console.Write("Check-in(dd/mm/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out(dd/mm/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

       
            Reserva reserva = new Reserva(numeroQuarto, checkIn, checkOut);
            Console.WriteLine("Reserva: \n" + reserva);
            Console.WriteLine();
            Console.WriteLine("Entre com os dados para atualizar a reserva");
            
            Console.Write("Check-in(dd/mm/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out(dd/mm/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());
            reserva.UpdateDates(checkIn, checkOut);
            Console.WriteLine("Atualização da reserva: \n"+reserva);

        }
        catch(DominioExecptions e) {
            Console.WriteLine("Erro ao concluir reserva: " + e.Message);
        }
        catch(FormatException e) {
            Console.WriteLine("Erro de formatação" + e.Message);
        }
        catch(Exception e) {
            Console.WriteLine("Erro inesperado " + e.Message);
        }







        }


    }








