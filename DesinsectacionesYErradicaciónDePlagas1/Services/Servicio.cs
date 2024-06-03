using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesinsectacionesYErradicaciónDePlagas1.Enum;
using DesinsectacionesYErradicaciónDePlagas1.Model;

namespace DesinsectacionesYErradicaciónDePlagas1.Services
{
    public class Servicio
    {
        public Cliente Cliente { get; set; } 
        public List<IEmpleado> PersonalAsignado { get; set; }
        public IAnimal Plaga { get; set; }
        public double Gastos { get; set; }
        public List<TipoRecurso> RecursosUsados { get; set; } 

        public Servicio()
        {
            RecursosUsados = new List<TipoRecurso>();
        }

        public double CalcularTotalGastosEmpleado()
        {
            double total = 0;
            foreach (var empleado in PersonalAsignado)
            {
                total += empleado.CalcularIngresoPorServicio(empleado.IngresoPorServicio);
            }
            return total;
        }

        public double CalcularTotalGastosVeneno()
        {
            return Plaga.CalcularCostoVeneno();
        }

        public double CalcularTotalGastosRecursos()
        {
            double total = 0;
            foreach (var recurso in RecursosUsados)
            {
                total += (double)recurso;
            }
            return total;
        }

        public double CalcularCostoTotalServicio()
        {
            return CalcularTotalGastosEmpleado() + CalcularTotalGastosVeneno() + CalcularTotalGastosRecursos();
        }
    }
}
