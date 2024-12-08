namespace Models.Produto;

public class Produto() {
  public string Nome {get; set;}
  public int Preco {get; set;}

  public void ExibirProduto(){
    Console.WriteLine($"Nome do Produto: {Nome}");
    Console.WriteLine($"Preco do Produto: {Preco}");
  }
}