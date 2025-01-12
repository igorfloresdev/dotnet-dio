
// Laço de repetição FOR
// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//   Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// Laço while

// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//   Console.WriteLine($"{contador}º Execução: {numero} x {contador} = {numero * contador}");
//   contador++;

//   if (contador == 6) // Sai da execução quando contador for 6
//   {
//     break;
//   }
// }

// Laço do-while

// int soma = 0, numero = 0;

// do
// {
//   Console.WriteLine("Digite um número (0 para parar): ");
//   numero = Convert.ToInt32(Console.ReadLine());

//   soma += numero;
// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

// Menu Interativo

using System.Diagnostics;

string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
  Console.Clear();
  Console.WriteLine("Digite a sua opção:");
  Console.WriteLine("1 - Cadastrar Cliente");
  Console.WriteLine("2 - Buscar Cliente");
  Console.WriteLine("3 - Apagar Cliente");
  Console.WriteLine("4 - Encerrar");

  opcao = Console.ReadLine();

  switch (opcao)
  {
    case "1":
      Console.WriteLine("Cadatro de Cliente");
      break;
    case "2":
      Console.WriteLine("Busca de Cliente");
      break;
    case "3":
      Console.WriteLine("Apagar Cliente");
      break;
    case "4":
      Console.WriteLine("Encerrar");
      exibirMenu = false; // Encerra o laço
      // Environment.Exit(0); // Sai do programa por completo
      break;
    default:
      Console.WriteLine("Opção inválida");
      break;
  }
}


