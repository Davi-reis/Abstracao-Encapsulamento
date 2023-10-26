using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_Abstracao_Encapsulamento.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        // Aqui a variavel é privada para não ter alteração em acesso externos
        private decimal Saldo;

        // Aqui a variavel "Saldo" foi encapsulado no metodo para só ser modificada dentro da condição abaixo;
        public void Sacar(decimal valor)
        {
            if(Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo disponivel");
            } 
        } 

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponivel é {Saldo}");
        }   
    }
}