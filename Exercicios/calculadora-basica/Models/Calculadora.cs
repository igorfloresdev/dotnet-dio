namespace Models.Calculadora;

public class Calculadora {
  public void Somar(int a, int b){
    Console.WriteLine($"resultado soma: {a + b}");
  }
  public void Subtrair(int a, int b) {
    Console.WriteLine($"resultado subtração: {a - b}");
  }
  public void Multiplicar(int a, int b){
    Console.WriteLine($"resultado multiplicação: {a * b}");
  }
  public void Dividir(int a, int b){
    Console.WriteLine($"resultado divisão: {a / b}");
  }
}
