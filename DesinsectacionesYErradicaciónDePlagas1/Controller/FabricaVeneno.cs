using DesinsectacionesYErradicaciónDePlagas1.Enum;
using DesinsectacionesYErradicaciónDePlagas1.Model;
using DesinsectacionesYErradicaciónDePlagas1.Services;

namespace DesinsectacionesYErradicaciónDePlagas1.Controller
{
    public class FabricaVeneno : IFabricaVeneno
    {
        public IVeneno CrearVeneno(string nombre, UnidadVeneno unidadMedida, double costo)
        {
            return new Veneno
            {
                Nombre = nombre,
                UnidadMedida = unidadMedida,
                Costo = costo
            };
        }
    }
}
