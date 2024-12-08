namespace Models.Relogio;

public class Relogio
{
  public void ExibirHorarioAtual()
  {
    DateTime horarioAtual = DateTime.Now;
    Console.WriteLine($"Horário Atual: {horarioAtual}");
  }
}