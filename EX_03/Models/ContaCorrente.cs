using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_03.Models
{
    public class ContaCorrente
    {
        public string NomeCorrentista;
        public int NumeroConta;
        public int NumeroAgencia;
        private decimal Saldo;

        public ContaCorrente(decimal SaldoInicial){
            Saldo = SaldoInicial;
        }

        public void Sacar(decimal Valor){
            if(Valor <= Saldo){
                Saldo = Saldo - Valor;
                Console.WriteLine("Saldo de R$" + Valor + " realizado com sucesso!");
            }else{
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public void ExibirSaldo(){
            Console.WriteLine("Seu saldo é: R$" + Saldo);
        }
    }
}