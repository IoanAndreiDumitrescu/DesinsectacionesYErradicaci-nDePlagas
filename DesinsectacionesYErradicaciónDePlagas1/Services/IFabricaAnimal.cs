using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesinsectacionesYErradicaciónDePlagas1.Services
{
    public interface IFabricaAnimal
    {
        IAnimal CrearAnimal(string nombre, IVeneno venenoParaMatar, double cantidadNecesariaParaMatar);
    }
}
