//1) Generar un número secreto
//aleatorio con la siguiente instruccion:

// Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

var Pruebas = 0;

for (int i = 0; i < numeroSecreto; i++)
{
    Console.WriteLine("Intente adivinar el número que eligió la computadora: ");
    int numeroUsuario = int.Parse(Console.ReadLine());

    //2) Pedir al usuario que ingrese un número y que
    //intente adivinar el número que eligió la computadora.

    Pruebas = Pruebas + 1;
    //3) Si el numero ingresado por el usuario es mayor
    //al número secreto, avisarle que es muy grande y que intente de nuevo y que
    //vuelva al paso 2.
    if (numeroUsuario > numeroSecreto)
    {
        Console.WriteLine("El número que ingresó es más grande que el " +
                                "de la computadora, intente de nuevo.");
    }
    //4) Si el numero ingresado es menor al número
    //secreto, avisarle que es muy chico, y que intente de nuevo volviendo al
    //paso 2.
    else if (numeroUsuario < numeroSecreto)
    {
        Console.WriteLine("El número que ingresó es más pequeño que el " +
                                "de la computadora, intente de nuevo.");
    }
    //5) Si el número ingresado coincide con el número
    //secreto, sacar el siguiente mensaje:
    else
    {
        Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}");
        Console.WriteLine($"Lo has logrado en {Pruebas} intentos!");
        break;
    
    }
}

