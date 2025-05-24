public class Perro
{
    public string? Raza { get; set; }
    public string? Nombre { get; set; }
    public int Edad { get; set; }
    public double Porcion { get; set; }
    public void Presentacion()
    {
        Console.WriteLine($"El perro de raza {Raza} se llama {Nombre} y tiene {Edad} años  ");
    }

    public void Comer()
    {
        Console.WriteLine($"El perro {Raza} come {Porcion} kg de comida"); 
    }
}