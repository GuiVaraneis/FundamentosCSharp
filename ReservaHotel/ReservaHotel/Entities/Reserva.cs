using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservaHotel.Entities.Exceptions;

namespace ReservaHotel.Entities {
    class Reserva {
        public int NumeroDoQuarto { get; set; }
        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public Reserva() { }

        public Reserva(int numeroDoQuarto, DateTime checkIn, DateTime checkOut) {
            if (checkOut <= checkIn) {
                throw new DominioExecptions("Data do Check-Out é anterior que a data do Check-In");
            }
            NumeroDoQuarto = numeroDoQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }


        public int Duration() {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;

        }

        public override string ToString() {
            return "Quarto: "
                + NumeroDoQuarto
                + ", Check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", Check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " Nights";
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut) {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now) {
                throw new DominioExecptions( "uma das datas é anterior a data atual.");
            }
            if (checkOut <= checkIn) {
               throw new DominioExecptions("Data do Check-Out deve ser futura a data do Check-In");
            }
     
            CheckIn = checkIn;
            CheckOut = checkOut;
            
        }
    }
}
