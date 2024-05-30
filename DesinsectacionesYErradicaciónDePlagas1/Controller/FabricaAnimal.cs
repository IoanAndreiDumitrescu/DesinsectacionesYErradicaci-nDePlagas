using DesinsectacionesYErradicaciónDePlagas1.Model;
using DesinsectacionesYErradicaciónDePlagas1.Services;

namespace DesinsectacionesYErradicaciónDePlagas1.Controller
{
    public class FabricaAnimal : IFabricaAnimal
    {
        public IAnimal CrearAnimal(string nombre, IVeneno venenoParaMatar, double cantidadNecesariaParaMatar)
        {
            return new Animal
            {
                Nombre = nombre,
                VenenoParaMatar = venenoParaMatar,
                CantidadNecesariaParaMatar = cantidadNecesariaParaMatar
            };
        }
    }
}
