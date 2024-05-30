using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesinsectacionesYErradicaciónDePlagas1.Services
{
    public interface IAnimal
    {
        string Nombre { get; set; }
        IVeneno VenenoParaMatar { get; set; }
        double CantidadNecesariaParaMatar { get; set; }
        double CalcularCostoVeneno();
    }
}
