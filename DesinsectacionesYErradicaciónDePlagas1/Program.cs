using DesinsectacionesYErradicaciónDePlagas1;
using DesinsectacionesYErradicaciónDePlagas1.Enum;
using DesinsectacionesYErradicaciónDePlagas1.Model;
using DesinsectacionesYErradicaciónDePlagas1.Services;

public class Program
{
    public static void Main()
    {
        var cliente = new Cliente
        {
            NombreCompleto = "Andrei Dumitrescu",
            Telefono = "643281233",
            Email = "andrei.ion.dumitrescu@gmail.com",
            CodigoPostal = "50194"
        };

        var empleado = new Empleado
        {
            Nombre = "Gheorghe",
            TipoEmpleado = TipoEmpleado.Peon,
            IngresoPorServicio = 50.00
        };

        var veneno = new Veneno
        {
            Nombre = "Veneno para ratas",
            UnidadMedida = UnidadVeneno.Gramo,
            Costo = 40.00
        };

        var animal = new Animal
        {
            Nombre = "Rata",
            VenenoParaMatar = veneno,
            CantidadNecesariaParaMatar = 5
        };

        var servicio = new Servicio
        {
            Cliente = cliente,
            PersonalAsignado = new List<IEmpleado> { empleado },
            Plaga = animal
        };

        Console.WriteLine($"Informacion del Servicio:");
        Console.WriteLine($"Cliente: {servicio.Cliente.NombreCompleto}");
        Console.WriteLine($"Telefono cliente: {servicio.Cliente.Telefono}");
        Console.WriteLine($"E-mail cliente: {servicio.Cliente.Email}");
        Console.WriteLine($"Plaga: {servicio.Plaga.Nombre}");
        Console.WriteLine($"Veneno Necesario: {servicio.Plaga.VenenoParaMatar.Nombre} - Cantidad: {servicio.Plaga.CantidadNecesariaParaMatar}");
        Console.WriteLine($"Empleado asignado: {string.Join(", ", servicio.PersonalAsignado.Select(e => e.Nombre))}");
        Console.WriteLine($"Gastos empleado: {servicio.CalcularTotalGastosEmpleado()}");
        Console.WriteLine($"Gastos veneno: {servicio.CalcularTotalGastosVeneno()}");
        Console.WriteLine($"Gastos recursos: {servicio.CalcularTotalGastosRecursos()}");
        Console.WriteLine($"Costo total del servicio: {servicio.CalcularCostoTotalServicio()}");


    }
}