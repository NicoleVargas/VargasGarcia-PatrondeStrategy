using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    interface ITipoConducción
    {
        string ObtenerDescripcion();
        int ObtenerPotencia(float decilitrosCombustible);
        int ObtenerIncrementoVelocidad(float decilitrosCombustible);
    }
}
