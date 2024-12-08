
namespace Classes.Models // Organização de classes, representa um caminho logico para indicar classes que estejam no mesmo domínio.
{
  public class Pessoa //Classe pessoa
  {
    public string Nome { get; set; } //Atributo nome
    public int Idade { get; set; } //Atributo idade

    public void Apresentar() //Metodo para se apresentar
    {
      Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos"); //Metodo executa método WriteLine da classe Console
    }
  }
}
