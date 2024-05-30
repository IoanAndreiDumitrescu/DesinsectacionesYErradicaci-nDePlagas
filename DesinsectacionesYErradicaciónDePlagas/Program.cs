using DesinsectacionesYErradicaciónDePlagas;

Recurso recurso1 = new Recurso { Nombre = "Recurso 1", CostoPorServicio = 100 };
Recurso recurso2 = new Recurso { Nombre = "Recurso 2", CostoPorServicio = 200 };

Trabajador trabajador1 = new Trabajador { Nombre = "Trabajador 1", IngresoPorServicio = 150 };
Trabajador trabajador2 = new Trabajador { Nombre = "Trabajador 2", IngresoPorServicio = 250 };

Servicio servicio1 = new Servicio
{
    NombreCliente = "Cliente 1",
    RecursosUsados = new List<Recurso> { recurso1, recurso2 },
    TrabajadoresAsignados = new List<Trabajador> { trabajador1 }
};

Servicio servicio2 = new Servicio
{
    NombreCliente = "Cliente 2",
    RecursosUsados = new List<Recurso> { recurso2 },
    TrabajadoresAsignados = new List<Trabajador> { trabajador1, trabajador2 }
};

var servicios = new List<Servicio> { servicio1, servicio2 };

CalculadorCostoServicio calculador = new CalculadorCostoServicio(servicios);

decimal costoTotal = calculador.CalcularCostoTotalServicios();

Console.WriteLine($"El costo total de todos los servicios es: {costoTotal}\n");

foreach (var servicio in servicios)
{
    Console.WriteLine($"Cliente: {servicio.NombreCliente}");
    Console.WriteLine("Recursos usados:");
    foreach (var recurso in servicio.RecursosUsados)
    {
        Console.WriteLine($"- {recurso.Nombre}: {recurso.CostoPorServicio}");
    }
    Console.WriteLine("Trabajadores asignados:");
    foreach (var trabajador in servicio.TrabajadoresAsignados)
    {
        Console.WriteLine($"- {trabajador.Nombre}: {trabajador.IngresoPorServicio}");
    }
    decimal costoServicio = servicio.RecursosUsados.Sum(recurso => recurso.CostoPorServicio) +
                servicio.TrabajadoresAsignados.Sum(trabajador => trabajador.IngresoPorServicio);

    Console.WriteLine($"Costo total del servicio: {costoServicio}");

    Console.WriteLine();
}

Console.WriteLine($"El costo total de todos los servicios es: {costoTotal}\n");
