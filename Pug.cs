public class Pug : Perro
{
    public Pug()
    {
        Raza = "Pug";
        Nombre = "Macarena";
        Edad = 2;
        Porcion = 2.3;
    }
      public Pug(string Nombre, int Edad, double Porcion)
    {
        Raza = "Pug";
        this.Nombre = Nombre;
        this.Edad = Edad;
        this.Porcion = Porcion;        
    }
}