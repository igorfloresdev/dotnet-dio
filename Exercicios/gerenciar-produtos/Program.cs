/*Crie uma classe Produto com os atributos Nome e Preco. No método void ExibirProduto, 
exiba os detalhes do produto no console. Instancie a classe no programa principal, adicione informações a dois produtos e exiba os detalhes.*/

using Models.Produto;

Produto produto = new Produto();
Produto produto2 = new Produto();

produto.Nome = "Notebook Pro";
produto.Preco = 10000;

produto2.Nome = "Smartphone Samsung";
produto2.Preco = 900;

produto.ExibirProduto();
produto2.ExibirProduto();
