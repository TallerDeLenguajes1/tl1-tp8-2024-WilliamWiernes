public class Tarea
{
    int tareaID; // Numero en ciclo iterativo
    string descripcion; // Descripción
    int duracion; // entre 10 y 100

    public int TareaID { get => tareaID; set => tareaID = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }

    public void MostrarTarea()
    {
        Console.WriteLine("");
        Console.WriteLine($"TareaID: {TareaID}");
        Console.WriteLine($"Descripción: {Descripcion}");
        Console.WriteLine($"Duración: {Duracion}");
        Console.WriteLine("");
    }
}