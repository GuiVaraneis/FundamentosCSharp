using System.Globalization;

namespace ClassificarProduto.Entities {
    internal class ProdutoImportado : Produto {
        private double CustoAdicional { get; set; }

        public ProdutoImportado(string nome, double preco, double custoAdicional)
            : base(nome, preco) {
            CustoAdicional = custoAdicional;
        }

        public override string DadosDoProduto() {
            return Nome
                + " $ "
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture)
                + " (Custo Adicional: $ "
                + CustoAdicional.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
        public double ValorTotal() {
            return Preco + CustoAdicional;
        }

    }
}
