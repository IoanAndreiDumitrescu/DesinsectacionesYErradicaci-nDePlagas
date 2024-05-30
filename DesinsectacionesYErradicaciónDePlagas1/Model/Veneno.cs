using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesinsectacionesYErradicaciónDePlagas1.Enum;
using DesinsectacionesYErradicaciónDePlagas1.Services;

namespace DesinsectacionesYErradicaciónDePlagas1.Model
{
    public class Veneno : IVeneno
    {
        public string Nombre { get; set; }
        public UnidadVeneno UnidadMedida { get; set; }
        public double Costo { get; set; }
    }
}
