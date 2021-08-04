using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class ConducciónDeportiva  
    {
        public class ConduccionDeportiva : ITipoConducción // Clase hija Conduccion hereda de clase padre ItipoConducción
        {
            public string ObtenerDescripcion()
            {
                return "Conduccion Deportiva";
            }

            public int ObtenerPotencia(float decilitrosCombustible)
            {
                return (int)(decilitrosCombustible * 0.987) + 5;
            }

            public int ObtenerIncrementoVelocidad(float decilitrosCombustible)
            {
                return (int)(decilitrosCombustible * 0.618) + 3;
            }
        }
    }
}
