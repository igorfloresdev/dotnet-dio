namespace Models.GeradorDeMensagem;

public class GeradorDeMensagem
{


  public void GerarMensagem()
  {
    Random random = new Random();
    string[] mensagem = [
      "Faça sempre o seu melhor!",
      "acredite que o melhor possa ser feito!",
      "Não espere, ponha em prática!",
      "Mesmo que pareça difícil, não pare!",
      "Só trabalhando é possível trilhar o caminho!",
      "Tenha coragem!"
      ];

    Console.WriteLine($"Mensagem gerada: {mensagem[random.Next(0,4)]}");
  }
}