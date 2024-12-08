namespace Models.Estoque;

public class Estoque
{
  public string Nome {get; set; }
  public int Quantidade { get; set;}

  public void Adicionar() {
    Quantidade++;
    Console.WriteLine($"Adicionado {Nome} ao estoque. Novo total: {Quantidade}");
  }

    public void Remover() {
    Quantidade--;
    Console.WriteLine($"Removido {Nome} ao estoque. Novo total: {Quantidade}");
  }
}