using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesinsectacionesYErradicaciónDePlagas1.Enum;

namespace DesinsectacionesYErradicaciónDePlagas1.Services
{
    public interface IFabricaVeneno
    {
        IVeneno CrearVeneno(string nombre, UnidadVeneno unidadMedida, double costo);
    }
}
