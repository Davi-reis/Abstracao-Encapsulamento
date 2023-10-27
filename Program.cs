using Aula_Abstracao_Encapsulamento.Models;


Professor p1 = new Professor();
p1.Nome = "Eduardo";
p1.Idade = 40;
p1.Salario = 1000;
p1.Apresentar();

/////////////////////////////////////

Aluno a1 = new Aluno();

a1.Nome = "Davi";
a1.Idade = 36;
a1.Nota = 10;

a1.Apresentar();

/////////////////////////////////////////////////////

ContaCorrente c1 = new ContaCorrente(123, 1000);

c1.ExibirSaldo();

c1.Sacar(500);

c1.ExibirSaldo();