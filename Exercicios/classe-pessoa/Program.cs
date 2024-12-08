/*Crie uma classe Pessoa com os atributos Nome e Idade. No método void MostrarDados, exiba o nome e a idade no console.
 No programa principal, crie uma instância de Pessoa, atribua valores aos atributos e chame o método MostrarDados. */

using Models.Pessoa;

Pessoa pessoa = new Pessoa();

pessoa.Nome = "Igor Flores";
pessoa.Idade = 29;

pessoa.MostrarDados();
