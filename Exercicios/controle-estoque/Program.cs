/*Crie uma classe Estoque com um atributo Quantidade. Adicione métodos para adicionar e remover itens 
(void Adicionar(int quantidade) e void Remover(int quantidade)) e exiba a quantidade atual após cada operação.*/

using Models.Estoque;

Estoque estoque = new Estoque();

estoque.Nome = "Carrinho de brinquedo";
estoque.Quantidade = 4;

estoque.Adicionar();
estoque.Adicionar();
estoque.Adicionar();
estoque.Adicionar();
estoque.Remover();
estoque.Remover();

