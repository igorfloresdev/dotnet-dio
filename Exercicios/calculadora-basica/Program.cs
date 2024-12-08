/*Crie uma classe Calculadora com métodos para somar, subtrair, multiplicar e dividir dois números. 
Cada método deve receber dois parâmetros (ex.: void Somar(int a, int b)). Instancie a classe no programa principal e chame os métodos.*/

using Models.Calculadora;

Calculadora calculadora = new Calculadora();

calculadora.Somar(10, 10);
calculadora.Subtrair(10, 5);
calculadora.Dividir(10, 2);
calculadora.Multiplicar(10, 2);
