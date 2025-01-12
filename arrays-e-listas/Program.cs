// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;

// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); // Redimensiona o valor do array dobrando tamanho

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length); // Copia o array e todos os seus elementos para um novo array.



// Console.WriteLine("Percorrendo o Array com o FOR");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//   Console.WriteLine($"Posição Nº: {contador} - {arrayInteiros[contador]}");
// }

// // Console.WriteLine("\nPercorrendo o Array com o FOREACH");
// // int contadorForeach = 0;
// // foreach (int valor in arrayInteiros)
// // {
// //   Console.WriteLine($"Posição Nº: {contadorForeach} - {valor}");
// //   contadorForeach++;
// // }

// TRABALHANDO COM LISTA

List<string> listaString = new List<string>(); //declarando uma lista do tipo string

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// Console.WriteLine("\nPercorrendo a lista com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++) //Percorre a lista
// {
//   Console.WriteLine($"Posição Nº: {contador} - {listaString[contador]}");
// }

// Console.WriteLine("\nPercorrendo a lista com o FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//   Console.WriteLine($"Posição Nº: {contadorForeach} - {item}");
//   contadorForeach++;
// }