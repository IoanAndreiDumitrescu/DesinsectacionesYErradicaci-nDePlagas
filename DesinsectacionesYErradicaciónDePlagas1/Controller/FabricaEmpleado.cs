using DesinsectacionesYErradicaciónDePlagas1.Enum;
using DesinsectacionesYErradicaciónDePlagas1.Model;
using DesinsectacionesYErradicaciónDePlagas1.Services;

namespace DesinsectacionesYErradicaciónDePlagas1.Controller
{
    public class FabricaEmpleado : IFabricaEmpleado
    {
        public IEmpleado CrearEmpleado(string nombre, TipoEmpleado tipoTrabajador, double ingresoPorServicio)
        {
            return new Empleado
            {
                Nombre = nombre,
                TipoEmpleado = tipoTrabajador,
                IngresoPorServicio = ingresoPorServicio
            };
        }
    }
}