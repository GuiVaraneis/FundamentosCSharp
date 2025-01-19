using System.Globalization;

namespace ClassificarProduto.Entities {
    class ProdutoUsado : Produto {
        private DateTime Data { get; set; }

        public ProdutoUsado(string nome, double preco, DateTime data) {
            Data = data;
        }

        public override string DadosDoProduto() {
            return Nome
            + " (used) $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + Data.ToString("dd/MM/yyyy")
                + ")";
        }

    }
}
