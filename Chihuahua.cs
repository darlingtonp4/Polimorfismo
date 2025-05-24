public class Chihuaha : Perro
{
    public Chihuaha()
    {
        Raza = "Chihuahua";
        Nombre = "Toby";
        Edad = 5;
        Porcion = 0.3;
    }
    public Chihuaha(string Nombre, int Edad, double Porcion)
    {
        Raza = "Chihuahua";
        this.Nombre = Nombre;
        this.Edad = Edad;
        this.Porcion = Porcion;        
    }

}