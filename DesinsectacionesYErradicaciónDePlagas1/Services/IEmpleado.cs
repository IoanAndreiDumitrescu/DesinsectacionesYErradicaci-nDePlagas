using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesinsectacionesYErradicaciónDePlagas1.Enum;

namespace DesinsectacionesYErradicaciónDePlagas1.Services
{
    public interface IEmpleado
    {
        string Nombre { get; set; }
        TipoEmpleado TipoEmpleado { get; set; }
        double IngresoPorServicio { get; set; }
        double CalcularIngresoPorServicio(double ingreso);
    }
}
