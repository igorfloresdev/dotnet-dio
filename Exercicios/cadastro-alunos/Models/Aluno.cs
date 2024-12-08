namespace Models.Aluno;

public class Aluno {
  public string Nome { get; set; }
  public int Idade { get; set; }
  public int NotaFinal { get; set; }

  public void MostrarStatus() {
    if(NotaFinal >= 7) {
      Console.WriteLine($"Aluno {Nome} com nota final {NotaFinal} está APROVADO!");
    } else {
      Console.WriteLine($"Aluno {Nome} com nota final {NotaFinal} está REPROVADO!");
    }
  }
}