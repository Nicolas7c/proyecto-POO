using System;

// Clase que representa la logica de compra de entradas para un espectaculo.
class Espectaculo
{
    // Atributo: precio individual de cada entrada.
    public decimal PrecioEntrada { get; private set; }

    // Constructor: inicializa el precio de las entradas.
    public Espectaculo(decimal precioEntrada)
    {
        if (precioEntrada <= 0)
        {
            throw new ArgumentException("El precio debe ser mayor que cero.");
        }

        PrecioEntrada = precioEntrada;
    }

    // Metodo que determina el descuento segun la cantidad comprada.
    public decimal ObtenerDescuento(int cantidad)
    {
        switch (cantidad)
        {
            case 2:
                return 0.10m;
            case 3:
                return 0.15m;
            case 4:
                return 0.20m;
            default:
                return 0m;
        }
    }

    // Metodo que calcula el valor antes del descuento.
    public decimal CalcularSubtotal(int cantidad)
    {
        return PrecioEntrada * cantidad;
    }

    // Metodo que calcula el valor final despues del descuento.
    public decimal CalcularTotal(int cantidad)
    {
        decimal subtotal = CalcularSubtotal(cantidad);
        decimal descuento = ObtenerDescuento(cantidad);
        return subtotal - (subtotal * descuento);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Se crea un objeto de la clase Espectaculo mediante su constructor.
        decimal precio = 25000m;
        Espectaculo evento = new Espectaculo(precio);

        Console.WriteLine("========================================");
        Console.WriteLine("       COMPRA DE ENTRADAS               ");
        Console.WriteLine("========================================");
        Console.WriteLine($"Precio por entrada: {evento.PrecioEntrada:C2}");

        int cantidad;

        // WHILE: valida que el usuario ingrese un numero entre 1 y 4.
        while (true)
        {
            Console.Write("¿Cuantas entradas desea comprar? (1 a 4): ");
            string entrada = Console.ReadLine() ?? "";

            if (int.TryParse(entrada, out cantidad) && cantidad >= 1 && cantidad <= 4)
            {
                break;
            }

            Console.WriteLine("Dato no valido. Ingrese una cantidad entre 1 y 4.\n");
        }

        decimal subtotal = evento.CalcularSubtotal(cantidad);
        decimal porcentajeDescuento = evento.ObtenerDescuento(cantidad);
        decimal valorDescuento = subtotal * porcentajeDescuento;
        decimal total = evento.CalcularTotal(cantidad);

        Console.WriteLine("\n--------------- DETALLE ---------------");

        // FOR: muestra cada entrada comprada, una por una.
        for (int i = 1; i <= cantidad; i++)
        {
            Console.WriteLine($"Entrada {i}: {evento.PrecioEntrada:C2}");
        }

        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Cantidad de entradas: {cantidad}");
        Console.WriteLine($"Subtotal:             {subtotal:C2}");
        Console.WriteLine($"Descuento ({porcentajeDescuento:P0}):   -{valorDescuento:C2}");
        Console.WriteLine($"TOTAL A PAGAR:        {total:C2}");
        Console.WriteLine("========================================");
        Console.WriteLine("Gracias por su compra.");
    }
}
