using System;

namespace Strategy
{
    //PATRON STRATEGY
    //El patrón Strategy, por su parte, no bucea en los detalles, sino que va un paso más allá: encapsulará un algoritmo completo ignorando los detalles de su implementación, permitiendo intercambiarlo en tiempo de ejecución para permitir actuar a la clase cliente con un comportamiento distinto.
    //El nombre de este patrón evoca la posibilidad de realizar un cambio de estrategia en tiempo de ejecución sustituyendo un objeto que se encargará de implementarla. 
    //No nos preocupará el “cómo”. De hecho, ni siquiera nos importará “el qué”: la clase que actúa como interfaz del patrón únicamente tendrá que exponer el método o métodos que deberá invocar el cliente.
    //
    //¿QUE PROBLEMA RESUELVE?
    //implementaremos el patrón a través de un hipotético módulo de la centralita del vehículo que nos permitirá alternar entre una conducción normal y deportiva.
    //La diferencia entre ambas será simple: mayor consumo, mayor potencia y mayor velocidad
    //Podríamos añadir más comportamientos “personalizados”, como el endurecimiento de la suspensión, pero con estos dos elementos será suficiente para captar la idea.
    //
    //Finalmente, el código que invoca a nuestro cliente, que será el siguiente:
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v = new Vehiculo();
            v.ConduccionDeportiva();
            v.Acelerar(2.4f);

            Console.WriteLine("");

            v.ConduccionNormal();
            v.Acelerar(2.4f);

            Console.ReadLine();
        }
    }
}
