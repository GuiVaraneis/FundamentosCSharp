
using Loja.Entities.Enum;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security;
using System.Text;

namespace Loja.Entities {
    class Pedido {
        public DateTime Date { get; set; }
        Cliente Cliente { get; set; }
        OrderStatus Status { get; set; }

        public List<ItemPedido> Items { get; set; } = new List<ItemPedido>();

        public Pedido(DateTime date, OrderStatus status, Cliente cliente) {
            Date = date;
            Status = status;
            Cliente = cliente;
        }


        public Pedido() { }

        public void addItem(ItemPedido items) {
            Items.Add(items);

        }
        
        public void removeItem(ItemPedido items) {
            Items.Remove(items);
        }

        public double Total() {
            double total = 0.0;
            foreach (ItemPedido item in Items) {
                 total += item.subtotal();

            }
            return total;

        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Horario do pedido: " + Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("Itens do pedido:");
            foreach (ItemPedido item in Items) {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

 
        
    }
}
