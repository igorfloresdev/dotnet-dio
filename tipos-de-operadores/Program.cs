//int a = 10; // Atribui com operador de atribuição (=) 
//int b = 20; // Atribui com operador de atribuição (=) 

//int c = a + b; // Atribui com operador de atribuição (=) 

//c = c + 5; // Atribui o proprio valor de C e soma mais 5
//c += 5; // Atribui o proprio valor de C e soma mais 5 porém combinando operadores



//Console.WriteLine(c); // Imprime no console a + b


//Converter tipos de variavies (Casting)

//int a = Convert.ToInt32("5"); // Converte a string para inteiro - Trata null como 0

//int a = int.Parse("5"); // Converte string para inteiro - trata null como erro

//Console.WriteLine(a);

// Conversão para string

// int inteiro = 5;
// string a = inteiro.ToString(); //Converte inteiro para string

// Console.WriteLine(a);

// Casting implicito

// int a = 5;
// double b = a; //Realiza a conversão implicita pois um inteiro cabe em um double

// Console.WriteLine(b);

//Ordem dos operadores

// double a = 4 / 2 + 2; //Respeita ordem dos operadores igual na matemática

// double a = 4 / (2 + 2); //Ordem de prioridade fazendo primeiro o que está nos parênteses

// Console.WriteLine(a);

// Conversão de maneira segura

string a = "15-";
// int b = 0;

int.TryParse(a, out int b); // Caso de erro continua o b sendo 0

Console.WriteLine(b);

