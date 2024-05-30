using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesinsectacionesYErradicaciónDePlagas
{
    public class CalculadorCostoServicio
    {
        private List<Servicio> servicios;

        public CalculadorCostoServicio(List<Servicio> servicios)
        {
            this.servicios = servicios;
        }

        public decimal CalcularCostoTotalServicios()
        {
            ConcurrentBag<decimal> totales = new ConcurrentBag<decimal>();

            // Usamos Parallel.For para calcular el costo total de cada servicio en paralelo
            Parallel.For(0, servicios.Count, i =>
            {
                decimal costoServicio = servicios[i].CalcularCostoTotal();
                totales.Add(costoServicio);
            });

            decimal costoTotal = 0;

            foreach (var total in totales)
            {
                costoTotal += total;
            }

            return costoTotal;
        }
    }
}
