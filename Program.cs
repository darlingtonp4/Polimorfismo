// See https://aka.ms/new-console-template for more information
Console.WriteLine("*****************************************");
Console.WriteLine("Presentación de perros");
Console.WriteLine("");
Pug pug = new Pug("Macarena", 2, 2.3);
pug.Presentacion();
pug.Comer();
Console.WriteLine("");
Chihuaha chihuahua = new Chihuaha();
chihuahua.Presentacion();
chihuahua.Comer();
Console.WriteLine("");
Labrador labrador = new Labrador("Lucky", 2, 3.3);
labrador.Presentacion();
labrador.Comer();
Console.WriteLine("");
Console.WriteLine("*****************************************");