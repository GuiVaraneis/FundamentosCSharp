using System.Xml;

class program {
    static void Main(string[] args) {

        
            Console.Write("SELECIONE O TIPO DE COMBUSTÍVEL\n" +
                           "1 - Álcool\n" +
                           "2 - Gasolina\n" +
                           "3 - Diesel\n" +
                           "4 - Cancelar e Encerrar\n");
        int qtd_alcool = 0;
        int qtd_Gasolina = 0;
        int qtd_Diesel = 0;

        Console.Write("Opção: ");  
        int opc = int.Parse(Console.ReadLine());
       
        
        while (opc != 4) {

            if (opc == 1) {
                qtd_alcool++;
            }
            else if(opc == 2) {
                qtd_Gasolina++;
            }
            else if(opc == 3){
                qtd_Diesel++;
            }

            Console.Write("SELECIONE O TIPO DE COMBUSTÍVEL: ");
            opc = int.Parse(Console.ReadLine()); 
        }
        
        Console.WriteLine("MUITO OBRIGADO :)");
        Console.WriteLine("Quantidade de vendas feitas de cada combústivel: ");
        
        Console.WriteLine($"Álcool: {qtd_alcool}");
        Console.WriteLine($"Gasolina: {qtd_Gasolina}");
        Console.WriteLine($"Álcool: {qtd_Diesel}");

    }


}