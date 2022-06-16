var opcionElegida = "S";

while (opcionElegida.ToUpper() == "S")
{
    //Borro la pantalla
    Console.Clear();

    //Pido el nombre de la persona
    Console.WriteLine("¡Buenas! Ingrese su nombre: ");
    var nombrePersona = Console.ReadLine();

    //Muestro el saludo
    //Console.WriteLine("¡Hola " + nombrePersona + "!");
    Console.WriteLine($"¡Hola {nombrePersona}!");

    Console.WriteLine("¿Desea continuar? S para sí, N para no.");
    opcionElegida = Console.ReadLine();
}

if (opcionElegida.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    Console.WriteLine("Opción no válida.");
}
