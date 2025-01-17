using Loja.Entities;
using Loja.Entities.Enum;
using System.Globalization;

namespace Loja {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("PEDIDO");

          Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("E-Mail: ");
            string email = Console.ReadLine();
            
            Console.Write("Data de Nascimento: ");
            DateTime nasc = DateTime.Parse((Console.ReadLine()));
            DateTime data = DateTime.Now;
            
            Cliente cliente = new Cliente(nome, email, nasc);
            Console.Write("Entre com o Status do pedido (): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Pedido pedido = new Pedido(data, status, cliente);

            
            Console.WriteLine("Quantos produtos serão adicionados ao pedido?");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Item #{i} do pedido: ");
                
                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();
                
                Console.Write("Quantidade: ");
                int qtd = int.Parse(Console.ReadLine());

                
                Console.Write("Valor do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Produto produto = new Produto(nomeProduto, preco);

                ItemPedido item = new ItemPedido(qtd, preco, produto);

                pedido.addItem(item);
               
            }




            Console.WriteLine("Dados do pedido: ");
            Console.WriteLine(pedido);




        }
    }
}