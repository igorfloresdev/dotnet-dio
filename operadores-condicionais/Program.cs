// int quantidadeEmEstoque = 10; 
// int quantidadeCompra = 0;

// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar compra: {possivelVenda}"); //verificação booleana

// if (quantidadeCompra == 0) //Verifica se a quantidade de compra é igual a 0
// {
//   Console.WriteLine("Venda invalida");
// }
// else if (possivelVenda) //Verifica se a quantidade em estoque é maior a que de compra
// {
//   //cai aqui se a condição for verdadeira
//   Console.WriteLine("Venda realizada");
// }
// else
// { 
//   //cai aqui se a condição for falsa
//   Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");  
// }

// Switch case
Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch (letra)
{
  case "a":
  case "e":
  case "i":
  case "o":
  case "u":
    Console.WriteLine("Você digitou uma vogal");
    break;
  default:
    Console.WriteLine("Não é uma vogal");
    break;
}

