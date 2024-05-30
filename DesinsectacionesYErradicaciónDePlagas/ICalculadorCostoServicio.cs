using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesinsectacionesYErradicaciónDePlagas
{
    public interface ICalculadorCostoServicio
    {
        decimal CalcularCostoServicio(Servicio servicio);
    }
}
