/*Crie uma classe Aluno com os atributos Nome, Idade e NotaFinal. Adicione um método void MostrarStatus que exiba se 
o aluno foi aprovado (nota >= 7). No programa principal, instancie a classe, atribua valores e mostre o status. */

using Models.Aluno;

Aluno aluno = new Aluno();

aluno.Nome = "Igor Flores";
aluno.Idade = 29;
aluno.NotaFinal = 10;

Aluno aluno2 = new Aluno();

aluno2.Nome = "Jonathan";
aluno2.Idade = 13;
aluno2.NotaFinal = 2;

aluno.MostrarStatus(); // Igor Flores foi aprovado
aluno2.MostrarStatus(); // Jonathan foi aprovado
