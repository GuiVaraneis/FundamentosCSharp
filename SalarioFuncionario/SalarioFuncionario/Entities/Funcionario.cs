using SalarioFuncionario.Entities.Enums;
using System.Collections.Generic;
namespace SalarioFuncionario.Entities {
    class Funcionario {
        public string Nome { get; set; }
        public NivelFuncionario NFunc { get; set; }

        public double SalarioBase { get; set; }

        public Departamento Departamento { get; set; }
        //utilizando o List para listar os vários contratos
        //por hora que o funcionário informará
        public List<ContratoHoras> Contracts { get; set; } = new List<ContratoHoras>();

        public Funcionario(){}

        public Funcionario(string nome, NivelFuncionario nFunc, double salarioBase, Departamento departamento) {
            Nome = nome;
            NFunc = nFunc;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void addContrato(ContratoHoras contract) { 
        
            Contracts.Add(contract);
        }

        public void removeContrato(ContratoHoras contract) {
            Contracts.Remove(contract);
        }

        public double SalarioTotal(int ano, int mes) {

            double soma = SalarioBase;
            foreach (ContratoHoras contract in Contracts) {
                if(contract.Date.Year == ano && 
                    contract.Date.Month == mes) {
                    soma += contract.ValorTotal();
                }
                
            }
            return soma;
        }


    }
}
