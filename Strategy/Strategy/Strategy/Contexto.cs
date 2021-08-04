using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Contexto
    {
        // Referencia a la interfaz
        private ITipoConducción tipoConduccion;

        // Propiedad que establecerá un nuevo tipo de conducción (cambio de estrategia)
        public ITipoConducción TipoConduccion
        {
            get { return tipoConduccion; }
            set { this.tipoConduccion = value; }
        }

        // Métodos de servicio (invocan los métodos implementados por las estrategias)
        public string ObtenerDescripcion()
        {
            return tipoConduccion.ObtenerDescripcion();
        }

        public int IncrementarVelocidad(float combustible)
        {
            return tipoConduccion.ObtenerIncrementoVelocidad(combustible);
        }

        public int IncrementarPotencia(float combustible)
        {
            return tipoConduccion.ObtenerPotencia(combustible);
        }
    }
}
