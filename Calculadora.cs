namespace EspacioCalculadora;

public enum TipoOperacion
{
    Suma,
    Resta,
    Multiplicacion,
    Division,
    Limpiar
}

public class Operacion
{
    private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion operacion;

    public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
    {
        this.resultadoAnterior = resultadoAnterior;
        this.nuevoValor = nuevoValor;
        this.operacion = operacion;
    }

    public double ResultadoAnterior { get => resultadoAnterior; }
    public double NuevoValor { get => nuevoValor; }
    public TipoOperacion Operacion1 { get => operacion; }
}

public class Calculadora
{
    private double dato;
    private List<Operacion> listaHistorialOperaciones = new List<Operacion>();

    public double Resultado { get => dato; }

    public void Sumar(double termino)
    {
        double resultadoAnterior = dato;
        dato += termino;
        listaHistorialOperaciones.Add(new Operacion(resultadoAnterior, dato, TipoOperacion.Suma));
    }

    public void Restar(double termino)
    {
        double resultadoAnterior = dato;
        dato -= termino;
        listaHistorialOperaciones.Add(new Operacion(resultadoAnterior, dato, TipoOperacion.Resta));
    }

    public void Multiplicar(double termino)
    {
        double resultadoAnterior = dato;
        dato *= termino;
        listaHistorialOperaciones.Add(new Operacion(resultadoAnterior, dato, TipoOperacion.Multiplicacion));
    }

    public void Dividir(double termino)
    {
        if (termino == 0)
        {
            Console.WriteLine("No está permitido la división por cero");
            return;
        }

        double resultadoAnterior = dato;
        dato /= termino;
        listaHistorialOperaciones.Add(new Operacion(resultadoAnterior, dato, TipoOperacion.Division));
    }

    public void Limpiar()
    {
        double resultadoAnterior = dato;
        dato = 0;
        listaHistorialOperaciones.Add(new Operacion(resultadoAnterior, dato, TipoOperacion.Limpiar));
    }

    public List<Operacion> ListaHistorialOperaciones { get => listaHistorialOperaciones; }
}