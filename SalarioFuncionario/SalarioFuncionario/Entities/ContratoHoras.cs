
namespace SalarioFuncionario.Entities {
     class ContratoHoras {
    
        public DateTime Date { get; set; }
        public double ValorPorHora { get; set; }    

        public int Horas { get; set; }

        public ContratoHoras(DateTime date, double valorPorHora, int horas) {

            Date = date;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double ValorTotal() {
            return Horas * ValorPorHora;
        }


    }
}
