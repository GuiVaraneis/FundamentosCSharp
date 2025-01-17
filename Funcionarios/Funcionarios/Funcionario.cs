using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Funcionario {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public Funcionario() { }

        public Funcionario(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
    
        public override string ToString() {

        return ($"ID: {Id}\nNome: {Nome}\nSalário: {Salario}");
    
        }

    public void implementarPorcentagem(double porcentagem) {
        Salario =  Salario * porcentagem / 100;
    }

        

    }

