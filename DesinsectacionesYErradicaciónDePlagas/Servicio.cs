using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesinsectacionesYErradicaciónDePlagas
{
    public class Servicio
    {
        public string NombreCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string CorreoElectronicoCliente { get; set; }
        public string CPCiente { get; set; }
        public decimal CostoTotalServicio { get; set; }
        public IList<Recurso> RecursosUsados { get; set; }
        public IList<Trabajador> TrabajadoresAsignados { get; set; }

        internal decimal CalcularCostoTotal()
        {
            decimal totalRecurso = RecursosUsados.Sum(recurso => recurso.CostoPorServicio);
            decimal totalTrabajador = TrabajadoresAsignados.Sum(trabajador => trabajador.IngresoPorServicio);

            return totalRecurso + totalTrabajador;
        }
    }
}
