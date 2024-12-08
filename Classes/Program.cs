using Classes.Models; //Indica o uso do namespace Classes.Models

Pessoa p = new Pessoa(); //instanciação da classe pessoa

p.Nome = "Igor"; //Atribui a string "Igor" para o atributo nome do objeto p da classe Pessoa
p.Idade = 29; //Atribui a int 29 para o atributo idade do objeto p da classe Pessoa


p.Apresentar(); // Chama o metodo aprensentar

// Alternativamente você pode usar 👇

// Classes.Models.Pessoa = new Classes.Models.Pessoa();
