namespace Models.ConversorDeTemperatura;

public class ConversorDeTemperatura {
  public void ConverterParaFahrenheit(double celsius){
    double fahrenheit = (celsius * 9/5) + 32;
    Console.WriteLine($"A temperatura {celsius}Cº é {fahrenheit}Fº");
  }

    public void ConverterParaCelsius(double fahrenheit){
    double celsius = (fahrenheit - 32) * 5/9;
    Console.WriteLine($"A temperatura {fahrenheit}Fº é {celsius}Cº");
  }
}