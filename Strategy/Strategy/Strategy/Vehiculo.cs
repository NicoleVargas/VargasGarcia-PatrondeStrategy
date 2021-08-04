using System;
using System.Collections.Generic;
using System.Text;
using static Strategy.ConducciónDeportiva;

namespace Strategy
{
    class Vehiculo
    {
        private Contexto contexto;
 
    public Vehiculo()
        {
            contexto = new Contexto();
        }

        public void ConduccionDeportiva()
        {
            ITipoConducción conduccionDeportiva = new ConduccionDeportiva();
            contexto.TipoConduccion = conduccionDeportiva;
        }

        public void ConduccionNormal()
        {
            ITipoConducción conduccionNormal = new ConducciónNormal();
            contexto.TipoConduccion = conduccionNormal;
        }

        // Métodos que invocan la funcionalidad implementada por la interfaz
        public void Acelerar(float combustible)
        {
            string descripcion = contexto.ObtenerDescripcion();
            int incrementoVelocidad = contexto.IncrementarVelocidad(combustible);
            int potencia = contexto.IncrementarPotencia(combustible);

            Console.WriteLine("Tipo de conducción " + descripcion);
            Console.WriteLine("Combustible inyectado: " + combustible);
            Console.WriteLine("Potencia proporcionada: " + potencia);
            Console.WriteLine("Incremento de velocidad: " + incrementoVelocidad);
        }
    }
}
