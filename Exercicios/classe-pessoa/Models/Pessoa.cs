namespace Models.Pessoa; // Namespace de pessoa

public class Pessoa{ //Cria classe
  public string Nome {get; set;} //Cria atributo Nome do tipo string
  public int Idade {get; set;} // Cria atributo Idade do tipo inteiro

  public void MostrarDados() { //Cria metodo de mostrar os dados
    Console.WriteLine($"Nome da pessoa: {Nome}");  //Imprime no console o nome da pessoa
    Console.WriteLine($"Idade da pessoa: {Idade}"); //Imprime no console a idade da pessoa
  }
}