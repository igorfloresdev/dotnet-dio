namespace Models.GeradorDeNumeros;

public class GeradorDeNumeros
{
  public void GerarNumeroAleatorio() {
    Random random = new Random();
    Console.WriteLine("Numero Gerado: " + random.Next(1, 100));
  }
}