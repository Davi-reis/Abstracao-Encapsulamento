using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_Abstracao_Encapsulamento.Models
{
    public class Pessoa
    {
        // Abstração das propriedades que só fazem sentido para o sistema
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}