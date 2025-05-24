public class Labrador : Perro
{
      public Labrador()
    {
        Raza = "Labrador";
        Nombre = "Lucky";
        Edad = 2;
        Porcion = 3.3;
    }
      public Labrador(string Nombre, int Edad, double Porcion)
    {
        Raza = "Labrador";
        this.Nombre = Nombre;
        this.Edad = Edad;
        this.Porcion = Porcion;        
    }
}