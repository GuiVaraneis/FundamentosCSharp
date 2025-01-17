

namespace CotacaoDolar {
     class ConversorDeMoeda {
        public static double IOF = 6.0;
        
        public static double DolarParaReal(double cotacao, double dolares) {
            double total = cotacao * dolares;
            return total + (total * IOF / 100);
        }

    }
}
