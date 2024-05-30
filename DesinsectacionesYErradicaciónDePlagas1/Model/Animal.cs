using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesinsectacionesYErradicaciónDePlagas1.Services;

namespace DesinsectacionesYErradicaciónDePlagas1.Model
{
    public class Animal : IAnimal
    {
        public string Nombre { get; set; }
        public IVeneno VenenoParaMatar { get; set; }
        public double CantidadNecesariaParaMatar { get; set; }

        public double CalcularCostoVeneno()
        {
            return VenenoParaMatar.Costo;
        }
    }
}
