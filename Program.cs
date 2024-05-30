using EspacioCalculadora;

Calculadora calcN = new Calculadora();

int continuar = 1, opcion;
double termino;

while (continuar == 1)
{
    opcion = Menu();

    switch (opcion)
    {
        case 1:
            termino = TerminoCorrecto();
            calcN.Sumar(termino);
            Console.WriteLine($"\nResultado de la suma: {calcN.Resultado}");
            break;
        case 2:
            termino = TerminoCorrecto();
            calcN.Restar(termino);
            Console.WriteLine($"\nResultado de la resta: {calcN.Resultado}");
            break;
        case 3:
            termino = TerminoCorrecto();
            calcN.Multiplicar(termino);
            Console.WriteLine($"\nResultado de la multiplicación: {calcN.Resultado}");
            break;
        case 4:
            termino = TerminoCorrecto();
            calcN.Dividir(termino);
            Console.WriteLine($"\nResultado de la división: {calcN.Resultado}");
            break;
        case 5:
            calcN.Limpiar();
            Console.WriteLine("\nLimpiado");
            break;
        default:
            Console.WriteLine("\nOpción no reconocida");
            break;
    }

    do
    {
        Console.Write("\nDesea realizar otra operación? [0] => NO [1] => SI: ");
    } while (!int.TryParse(Console.ReadLine(), out continuar) || (continuar != 0 && continuar != 1));
}

// Mostrando historial de operaciones
Console.WriteLine("\nHistorial de Operaciones realizadas:");
foreach(var operacion in calcN.ListaHistorialOperaciones)
{
    Console.WriteLine($"\nResultado Anterior: {operacion.ResultadoAnterior}");
    Console.WriteLine($"Nuevo Valor: {operacion.NuevoValor}");
    Console.WriteLine($"Tipo de Operación: {operacion.Operacion1}");
}

static int Menu()
{
    int opcion;

    Console.WriteLine("\n1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Limpiar");

    do
    {
        Console.Write("Opción: ");
    } while (!int.TryParse(Console.ReadLine(), out opcion));

    return opcion;
}

static double TerminoCorrecto()
{
    double termino;

    do
    {
        Console.Write("\nIngrese un número: ");
    } while (!double.TryParse(Console.ReadLine(), out termino));

    return termino;
}