
public class Estudiante
{
    public string? Nombre { get; set; }
    public double Nota { get; set; }

    public void MostrarInfo()
    {
        Console.WriteLine("Estudiante ");
        Console.WriteLine("--------------------");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Nota: {Nota}");
        Console.WriteLine("--------------------");
    }  
}