﻿using System.Globalization;

namespace ClassificarProduto.Entities {
    class Produto {
        public string Nome { get; set; }

        public double Preco { get; set; }

        public Produto() { }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public virtual string DadosDoProduto() {
            return Nome
            + " $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
