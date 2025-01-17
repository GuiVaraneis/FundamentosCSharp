using System;
using System.Globalization;
class Produto {
    
    private string _nomeProduto;
    public double Valor { get; private set; }
    public int QtdEstoque { get; private set; }
    
    public Produto(string nomeProduto, double valor, int qtd_estoque) { 
        _nomeProduto = nomeProduto;
        Valor = valor;
        QtdEstoque = qtd_estoque;
    }

    public string Nome {
        get { return _nomeProduto; } set {
            if (value != null && value.Length > 1) {
                _nomeProduto = value;
            }
        }
    }
  


    public double ValorTotalEmEstoque() {
           return QtdEstoque * Valor;
    } 

    public void AdicionarProdutos (int quantidade) {
        QtdEstoque = QtdEstoque + quantidade;
    }

    public void RemoverProdutos(int quantidade) {
        QtdEstoque = QtdEstoque - quantidade;
    }

    public override string ToString() {
        return  "Produto: " + _nomeProduto +
                "\nPreço: R$ " + Valor + 
                "\nQuantidade em estoque: " + QtdEstoque +
                "\nValor Total: "  + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
           
    }


}

