using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesinsectacionesYErradicaciónDePlagas1.Enum;
using DesinsectacionesYErradicaciónDePlagas1.Services;

namespace DesinsectacionesYErradicaciónDePlagas1.Model
{
    public class Empleado : IEmpleado
    {
        public string Nombre { get; set; }
        public TipoEmpleado TipoEmpleado { get; set; }
        public double IngresoPorServicio { get; set; }

        public double CalcularIngresoPorServicio(double ingreso)
        {
            return IngresoPorServicio * (1 + 0.2);
        }
    }
}
