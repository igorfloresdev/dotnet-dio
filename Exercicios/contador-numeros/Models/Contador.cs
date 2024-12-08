namespace Models.Contador;

public class Contador{
  public int Numero {get; set;}

  public void Incrementar() {
    Numero++;
    Console.WriteLine($"Numero Incrementado: {Numero}");
  }

  public void Decrementar() {
    Numero--;
    Console.WriteLine($"Numero Decrementado: {Numero}");
  }
}