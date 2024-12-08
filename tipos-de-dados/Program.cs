DateTime dataAtual = DateTime.Now; //Variavel do tipo DatTime pegando a data atual
dataAtual = dataAtual.AddDays(5); //Adiciona 5 dias

string apresentacao = "Olá, seja bem vindo"; //Variável do tipo string

int quantidade = 1; //Variável do tipo inteiro

quantidade = 10; //Atribuição de valor para variável

double altura = 1.80; //Variável do tipo double (Casa decimais)

decimal preco = 1.80M; //Variável do tipo decimal (Utilizado para valores)

bool condiocao = true; // Valor booleano, representa verdadeiro ou false

Console.WriteLine($"Apresentação: {apresentacao}");
Console.WriteLine($"Quantidade: {quantidade}");
Console.WriteLine($"Altura: {altura.ToString("0.00")}"); //representa a altura com casas decimais
Console.WriteLine($"Preço: {preco}");
Console.WriteLine($"Condição: {condiocao}");
Console.WriteLine($"DataAtual: {dataAtual.ToString("dd/MM/yyyy HH:mm")}"); //Data e hora atual em string fomatada
