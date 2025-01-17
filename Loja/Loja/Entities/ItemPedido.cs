using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Entities {
    class ItemPedido {
        public int QtdItem { get; set; }

        public double Preco { get; set; }

        public Produto Produto { get; set; }

        public ItemPedido() { }
        public ItemPedido(int qtdItem, double preco, Produto produto) {
            QtdItem = qtdItem;
            Preco = preco;
            Produto = produto;
        }

        
        public double subtotal() {

            return Preco * QtdItem;
        }

        public override string ToString() {
            return Produto.Nome +
                 ", R$" +
                 Preco.ToString("F2", CultureInfo.InvariantCulture) +
                 ", quantidade: " + QtdItem +
                 ", subtotal: R$ " +
                 subtotal().ToString("F2", CultureInfo.InvariantCulture);
        }




    }
}
