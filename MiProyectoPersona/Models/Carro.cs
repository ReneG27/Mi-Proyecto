
public class Carro  
{
    public string? Marca { get; set; }
    public int Anio { get; set; }

    public void Arrancar()
    {
        Console.WriteLine("Carro ");
        Console.WriteLine("--------------------");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Anio: {Anio}");
        Console.WriteLine("--------------------");
    }  
}