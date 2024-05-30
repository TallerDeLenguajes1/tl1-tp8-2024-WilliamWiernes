// Listas
var ListaTareasPendientes = new List<Tarea>();
var ListaTareasRealizadas = new List<Tarea>();

// Número aleatorio de tareas
var Aleatorio = new Random();
var NumRan = Aleatorio.Next(1, 11); // 1 a 10 tareas

for (int i = 0; i < NumRan; i++)
{
    var Tarea = new Tarea();
    var Duracion = Aleatorio.Next(10, 101);

    Tarea.TareaID = i;
    Tarea.Descripcion = $"Descripción {i}.";
    Tarea.Duracion = Duracion;

    ListaTareasPendientes.Add(Tarea);
}

// Interfaz para mover las tareas pendientes a realizadas
Console.WriteLine("Interfaz marcar Tarea Pendiente como Realizada:");
Console.WriteLine("Lista de Tareas Pendientes:");
foreach (var Tarea in ListaTareasPendientes)
{
    Tarea.MostrarTarea();
}

int SeleccionID;
Console.Write("Seleccione el ID de la Tarea que desea marcar como Realizada: ");
if (int.TryParse(Console.ReadLine(), out SeleccionID)) // Si la entrada es correcta
{
    var TareaBusqID = ListaTareasPendientes.Find(t => t.TareaID == SeleccionID); // Busco la tarea

    if (TareaBusqID != null) // Si encuentro la tarea
    {
        ListaTareasRealizadas.Add(TareaBusqID);
        ListaTareasPendientes.Remove(TareaBusqID);

        Console.WriteLine($"La tarea con ID '{SeleccionID}' ha sido marcada como realizada.");
    }
    else
    {
        Console.WriteLine($"La tarea con ID '{SeleccionID}' no se pudo encontrar.");
    }
}
else
{
    Console.WriteLine("Entrada no válida.");
}

Console.WriteLine("Lista de Tareas Pendientes:");
foreach (var Tarea in ListaTareasPendientes)
{
    Tarea.MostrarTarea();
}

Console.WriteLine("Lista de Tareas Realizadas:");
foreach (var Tarea in ListaTareasRealizadas)
{
    Tarea.MostrarTarea();
}

// Interfaz buscar tareas pendientes por descripción;
Console.WriteLine("");
string BusquedaDesc;

Console.WriteLine("Intefaz buscar Tarea Pendiente por Descripción:");
Console.Write("Ingrese su búsqueda: ");
BusquedaDesc = Console.ReadLine();

var TareaBusqDesc = ListaTareasPendientes.Find(t => t.Descripcion == BusquedaDesc); // Busco la tarea

if (TareaBusqDesc != null) // Si encuentro la tarea
{
    TareaBusqDesc.MostrarTarea();
}
else
{
    Console.WriteLine($"La tarea con Descripción '{BusquedaDesc}' no se pudo encontrar.");
}