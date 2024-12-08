/*Crie uma classe Contador com um atributo público Numero e métodos para incrementar e decrementar este valor 
(void Incrementar() e void Decrementar()). Exiba o valor do contador no console após cada operação. */

using Models.Contador;

Contador contador = new Contador();

contador.Numero = 10;
contador.Incrementar(); //Numero vale 11
contador.Incrementar(); //Numero vale 12
contador.Incrementar(); //Numero vale 13
contador.Incrementar(); //Numero vale 14
contador.Incrementar(); //Numero vale 15
contador.Decrementar(); //Numero vale 14
contador.Decrementar(); //Numero vale 13